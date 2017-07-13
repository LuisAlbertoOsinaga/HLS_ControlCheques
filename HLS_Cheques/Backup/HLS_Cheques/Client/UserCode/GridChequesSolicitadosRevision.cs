using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using System.Windows;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;

using LightSwitchApplication.UserCode;
using System.Collections.Specialized;

namespace LightSwitchApplication
{
    public partial class GridChequesSolicitadosRevision
    {
        partial void ChequesPorCuentaBancoYSituacion_Loaded(bool succeeded)
        {
            Mensaje = ChequesPorCuentaBancoYSituacion.Count == 0 ? Globales.MensajeNoHayRegistros : string.Empty;
        }

        partial void GridChequesSolicitadosRevision_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            ChequeSituacion = Globales.SituacionCheque_Solicitado;

            IContentItemProxy btnCbte = this.FindControl("btnCbte");
            btnCbte.IsEnabled = false;
            IContentItemProxy btnFactura = this.FindControl("btnFactura");
            btnFactura.IsEnabled = false;
            IContentItemProxy btnDocs = this.FindControl("btnDocs");
            btnDocs.IsEnabled = false;
            
            IContentItemProxy btnRechazo = this.FindControl("btnRechazo");
            btnRechazo.IsEnabled = false;
        }

        partial void Cuenta_Changed()
        {
            CuentaMoneda = Cuenta != null ? Cuenta.Moneda : string.Empty;
            ChequesPorCuentaBancoYSituacion.Load();
        }

        partial void btnCbte_Execute()
        {
            if (ChequesPorCuentaBancoYSituacion.SelectedItem != null)
                this.OpenModalWindow("DialogImgCbte");
        }

        partial void btnFactura_Execute()
        {
            if (ChequesPorCuentaBancoYSituacion.SelectedItem != null)
                this.OpenModalWindow("DialogImgFactura");
        }

        partial void btnDocs_Execute()
        {
            if (ChequesPorCuentaBancoYSituacion.SelectedItem != null)
                this.OpenModalWindow("DialogImgDocs");
        }

        partial void btnRechazoSolicitud_Execute()
        {
            if (ChequesPorCuentaBancoYSituacion.SelectedItem != null)
                this.OpenModalWindow("DialogSolicitudRechazo");
        }

        partial void btnRechazoCancelar_Execute()
        {
            this.CloseModalWindow("DialogSolicitudRechazo");
        }

        partial void btnRechazoConfirmar_Execute()
        {
            Cheque[] chequesARechazar = ChequesARechazar(RechazoSolicitudNro);
            if (chequesARechazar != null && chequesARechazar.Length > 0)
            {
                MessageBoxResult result = this.ShowMessageBox(string.Format("Confirma rechazo de la Solicitud. Nro {0}", RechazoSolicitudNro), 
                                                                " ", MessageBoxOption.YesNo);
                if(result == MessageBoxResult.Yes)
                    RechazaSolicitud(chequesARechazar);
            }
            else
                this.ShowMessageBox("No hay cheques por rechazar con este Nro de solicitud!");
            this.CloseModalWindow("DialogSolicitudRechazo");
        }

        private void RechazaSolicitud(Cheque[] cheques)
        {
            foreach (Cheque chq in cheques)
            {
                chq.Situacion = Globales.SituacionCheque_Preparado;
                chq.Solicitar = false;
            }
            Save();
            ChequesPorCuentaBancoYSituacion.Refresh();
        }

        private Cheque[] ChequesARechazar(int? RechazoSolicitudNro)
        {
            int solicitudNro = RechazoSolicitudNro.GetValueOrDefault();
            var chequesARechazar = (from chq in ChequesPorCuentaBancoYSituacion
                          where chq.SolicitudNro == solicitudNro
                          select chq).ToArray();
            return chequesARechazar;
        }

        partial void ChequesPorCuentaBancoYSituacion_Changed(NotifyCollectionChangedEventArgs e)
        {
            IContentItemProxy btnCbte = this.FindControl("btnCbte");
            IContentItemProxy btnFactura = this.FindControl("btnFactura");
            IContentItemProxy btnDocs = this.FindControl("btnDocs");
            IContentItemProxy btnRechazo = this.FindControl("btnRechazo");
            if (ChequesPorCuentaBancoYSituacion.SelectedItem != null)
            {
                btnCbte.IsEnabled = true;
                btnFactura.IsEnabled = true;
                btnDocs.IsEnabled = true;

                btnRechazo.IsEnabled = true;
            }
            else
            {
                btnCbte.IsEnabled = false;
                btnFactura.IsEnabled = false;
                btnDocs.IsEnabled = false;

                btnRechazo.IsEnabled = false;
            }
        }
    }
}
