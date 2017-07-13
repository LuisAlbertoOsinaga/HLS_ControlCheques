using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;

using LightSwitchApplication.UserCode;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Specialized;

namespace LightSwitchApplication
{
    public partial class GridChequesSolicitud
    {
        partial void ChequesPorCuentaBancoYSituacion_Loaded(bool succeeded)
        {
            Mensaje = ChequesPorCuentaBancoYSituacion.Count == 0 ? Globales.MensajeNoHayRegistros : string.Empty;
            FechaSolicitud = DateTime.Now;
        }

        partial void GridChequesSolicitud_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            ChequeSituacion = Globales.SituacionCheque_Preparado;
            IContentItemProxy btnAdd = this.FindControl("gridAddNew");
            btnAdd.IsEnabled = false;

            IContentItemProxy btnSolicitar = this.FindControl("btnSolicitar");
            btnSolicitar.IsEnabled = false;
        }

        partial void Cuenta_Changed()
        {
            CuentaMoneda = Cuenta != null ? Cuenta.Moneda : string.Empty;

            ChequesPorCuentaBancoYSituacion.Load();

            IContentItemProxy btnAdd = this.FindControl("gridAddNew");
            btnAdd.IsEnabled = Cuenta != null;
        }

        partial void gridAddNew_CanExecute(ref bool result)
        {
            // Write your code here.

        }

        partial void gridAddNew_Execute()
        {
            Cheque chq = ChequesPorCuentaBancoYSituacion.AddNew();
            chq.CuentaBanco = Cuenta;
            chq.FechaCreacion = DateTime.Now;
            chq.Situacion = Globales.SituacionCheque_Preparado;
            chq.UsuarioCreacion = Application.User.FullName;
            chq.Solicitar = false;
        }

        partial void Solicitar_Execute()
        {
            // Salva cambios
            this.DataWorkspace.ApplicationData.SaveChanges();
            
            // Consigue cheques por confirmar            
            Cheque[] cheques = (from chq in ChequesPorCuentaBancoYSituacion
                                where chq.Solicitar == true
                                select chq).ToArray();
            if (cheques == null || cheques.Length == 0)
            {
                this.ShowMessageBox("No hay cheques marcados para solicitar!", "SOLICITUD DE CHEQUES", MessageBoxOption.Ok);
                return;
            }

            // Valida Fecha
            if(!FechaSolicitud.HasValue)
            {
                this.ShowMessageBox("Fecha de Solicitud inválida!", "SOLICITUD DE CHEQUES", MessageBoxOption.Ok);
                return;
            }

            // Valida Girador
            if (Girador == null)
            {
                this.ShowMessageBox("Girador en blanco!", "SOLICITUD DE CHEQUES", MessageBoxOption.Ok);
                return;
            }

            // Consigue nombre de Empresa
            Parametro[] parms = (from Parametro p in this.DataWorkspace.ApplicationData.Parametros
                                 where p.Categoria == Globales.CategoriaEmpresa &&
                                         p.Clave == Globales.ClaveNombre
                                 select p).ToArray();
            string empresa = parms != null && parms.Length > 0 ? parms[0].Valor : string.Empty;

            // Consigue numero de solicitud
            Secuencia secu = ServicioSecuencia.GetSecuencia(Globales.CategoriaSolicitudCheque, Globales.ClaveSolicitudCheque);
            if (secu == null)
            {
                ServicioSecuencia.InitSecuencia(Globales.CategoriaSolicitudCheque, Globales.ClaveSolicitudCheque);
                secu = ServicioSecuencia.GetSecuencia(Globales.CategoriaSolicitudCheque, Globales.ClaveSolicitudCheque);
            }

            // Confirma Solicitud
            int nroSolicitud = secu != null ? secu.NroActual + 1 : -1;
            StringBuilder sbe = new StringBuilder();
            StringBuilder sb = new StringBuilder();
            decimal total = 0M;

            sbe.AppendFormat("{0} " + Environment.NewLine, empresa);
            sbe.AppendFormat("{0} - {1} " + Environment.NewLine, Cuenta.Identidad, CuentaMoneda);
            sbe.AppendFormat("{0} Nro. {1} de {2} " + Environment.NewLine + Environment.NewLine, "SOLICITUD DE CHEQUES", nroSolicitud, DateTime.Now.ToString("dd/MM/yyyy"));
            sbe.AppendFormat("Sr(a). {0} " + Environment.NewLine, Girador.Nombre);
            sbe.AppendFormat("Por favor sirvase emitir los siguientes cheques: " + Environment.NewLine + Environment.NewLine);

            sb.AppendFormat("{0} | {1} | {2} | {3}" + Environment.NewLine + Environment.NewLine,
                            "Cheque", "Concepto", "Beneficiario", "Monto");
            foreach (Cheque chq in cheques)
            {
                sb.AppendFormat("{0} | {1} | {2} | {3}. {4} " + Environment.NewLine,
                                chq.Nro, chq.Concepto, chq.Beneficiario, CuentaMoneda, chq.Monto.ToString());
                total += chq.Monto;
            }
            sb.Append(Environment.NewLine + "Total " + CuentaMoneda + ": " + total.ToString());
            MessageBoxResult result = this.ShowMessageBox(sbe.ToString() + sb.ToString(), " ", MessageBoxOption.OkCancel);
            if (result == MessageBoxResult.Cancel)
                return;

            // Procesa Solicitud
            ProcesaSolicitudCheques(cheques, sbe.ToString() + sb.ToString());
        }

        private void ProcesaSolicitudCheques(Cheque[] cheques, string mensaje)
        {
            // Consigue numero de solicitud
            Secuencia secu = ServicioSecuencia.PeekSecuencia(Globales.CategoriaSolicitudCheque, Globales.ClaveSolicitudCheque);
            int nroSolicitud = secu != null ? secu.NroActual: -1;

            // Arma mensaje con Nro Solicitud
            // mensaje = string.Format("{0} Nro. {1}  ", "SOLICITUD DE CHEQUES", nroSolicitud) + mensaje;

            // Envia Correos
            EnviaCorreosSolicitud(mensaje);

            // Cambia Situacion cheques a Solicitados
            foreach (Cheque chq in cheques)
            {
                chq.Situacion = Globales.SituacionCheque_Solicitado;
                chq.SolicitudNro = nroSolicitud;
                chq.Certificado = false;
                chq.UsuarioSolicitud = Application.User.FullName;
                chq.FechaSolicitud = FechaSolicitud;
                chq.Girador = Girador;
            }
            
            // Salva Cheques
            this.DataWorkspace.ApplicationData.SaveChanges();
            ChequesPorCuentaBancoYSituacion.Refresh();

            // Mensaje de exito
            this.ShowMessageBox("Solicitud de Cheques enviada!", " ", MessageBoxOption.Ok);
        }

        private void EnviaCorreosSolicitud(string mensaje)
        {
            ServicioMail.SendMailSolicitudCheques(mensaje);
        }

        partial void ChequesPorCuentaBancoYSituacion_Changed(NotifyCollectionChangedEventArgs e)
        {
            IContentItemProxy btnSolicitar = this.FindControl("btnSolicitar");
            if (ChequesPorCuentaBancoYSituacion.SelectedItem != null)
            {
                btnSolicitar.IsEnabled = true;
            }
            else
            {
                btnSolicitar.IsEnabled = false;
            }
        }

        partial void DialogSolicitudCancelar_Execute()
        {
            this.CloseModalWindow("DialogSolicitud");
        }

        partial void GridChequesSolicitud_Saved()
        {
            ChequesPorCuentaBancoYSituacion.Refresh();
        }
    }
}
