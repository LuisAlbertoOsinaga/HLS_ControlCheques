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
using System.Collections.Specialized;

namespace LightSwitchApplication
{
    public partial class GridChequesEmision
    {
        partial void ChequesPorCuentaBancoYSituacion_Loaded(bool succeeded)
        {
            Mensaje = ChequesPorCuentaBancoYSituacion.Count == 0 ? Globales.MensajeNoHayRegistros : string.Empty;
        }

        partial void GridChequesEmision_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            ChequeSituacion = Globales.SituacionCheque_Solicitado;
            
            IContentItemProxy btnCbte = this.FindControl("btnCbte");
            btnCbte.IsEnabled = false;
            IContentItemProxy btnFact = this.FindControl("btnFactura");
            btnFact.IsEnabled = false;
            IContentItemProxy btnDocs = this.FindControl("btnDocs");
            btnDocs.IsEnabled = false;
            IContentItemProxy btnCheque = this.FindControl("btnCheque");
            btnCheque.IsEnabled = false;
            
            IContentItemProxy btnEmitir = this.FindControl("btnEmitir");
            btnEmitir.IsEnabled = false;
        }

        partial void Cuenta_Changed()
        {
            CuentaMoneda = Cuenta != null ? Cuenta.Moneda : string.Empty;
            ChequesPorCuentaBancoYSituacion.Load();
        }

        partial void Emitir_Execute()
        {
            if (ChequesPorCuentaBancoYSituacion.SelectedItem != null)
                this.OpenModalWindow("DialogEmision");
        }

        partial void btnCbte_Execute()
        {
            if (ChequesPorCuentaBancoYSituacion.SelectedItem != null)
                this.OpenModalWindow("DialogCbte");
        }

        partial void btnFactura_Execute()
        {
            if (ChequesPorCuentaBancoYSituacion.SelectedItem != null)
                this.OpenModalWindow("DialogFactura");
        }

        partial void btnDocs_Execute()
        {
            if (ChequesPorCuentaBancoYSituacion.SelectedItem != null)
                this.OpenModalWindow("DialogDocs");
        }

        partial void btnCheque_Execute()
        {
            if (ChequesPorCuentaBancoYSituacion.SelectedItem != null)
                this.OpenModalWindow("DialogCheque");
        }

        partial void ChequesPorCuentaBancoYSituacion_Changed(NotifyCollectionChangedEventArgs e)
        {
            IContentItemProxy btnCbte = this.FindControl("btnCbte");
            IContentItemProxy btnFactura = this.FindControl("btnFactura");
            IContentItemProxy btnDocs = this.FindControl("btnDocs");
            IContentItemProxy btnCheque = this.FindControl("btnCheque");
            IContentItemProxy btnEmitir = this.FindControl("btnEmitir");
            if (ChequesPorCuentaBancoYSituacion.SelectedItem != null)
            {
                btnCbte.IsEnabled = true;
                btnFactura.IsEnabled = true;
                btnDocs.IsEnabled = true;
                btnCheque.IsEnabled = true;

                btnEmitir.IsEnabled = true;
            }
            else
            {
                btnCbte.IsEnabled = false;
                btnFactura.IsEnabled = false;
                btnDocs.IsEnabled = false;
                btnCheque.IsEnabled = false;

                btnEmitir.IsEnabled = false;
            }
        }

        partial void CancelarEmision_Execute()
        {
            this.CloseModalWindow("DialogEmision");
        }

        partial void ConfirmarEmision_Execute()
        {
            Cheque chq = ChequesPorCuentaBancoYSituacion.SelectedItem;

            if (chq.Girador == null)
            {
                this.ShowMessageBox("Girador en blanco!");
                return;
            }
            if(!chq.FechaGiro.HasValue || chq.FechaGiro < new DateTime(2000, 1, 1))
            {
                this.ShowMessageBox("Fecha de giro inválida!");
                return;
            }

            // Cambios
            chq.Situacion = Globales.SituacionCheque_Emitido;
            chq.UsuarioEmision = Application.User.FullName;
            chq.FechaEmision = DateTime.Now;

            // Salva Cheques
            this.DataWorkspace.ApplicationData.SaveChanges();
            ChequesPorCuentaBancoYSituacion.Refresh();

            // Mensaje de exito
            this.ShowMessageBox("Emisión de Cheques realizada!", " ", MessageBoxOption.Ok);

            this.CloseModalWindow("DialogEmision");
        }
    }
}
