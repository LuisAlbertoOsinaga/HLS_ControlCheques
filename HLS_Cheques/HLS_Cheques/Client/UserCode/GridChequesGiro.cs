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
    public partial class GridChequesGiro
    {
        partial void ChequesPorCuentaBancoYSituacion_Loaded(bool succeeded)
        {
            Mensaje = Cuenta != null && ChequesPorCuentaBancoYSituacion.Count == 0 ? Globales.MensajeNoHayRegistros : string.Empty;
        }

        partial void GridChequesGiro_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            ChequeSituacion = Globales.SituacionCheque_Solicitado;
            
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

        partial void ChequesPorCuentaBancoYSituacion_Changed(NotifyCollectionChangedEventArgs e)
        {
            IContentItemProxy btnEmitir = this.FindControl("btnEmitir");
            if (ChequesPorCuentaBancoYSituacion.SelectedItem != null)
            {
                btnEmitir.IsEnabled = true;
            }
            else
            {
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
            this.ShowMessageBox("Giro de cheque registrado!", " ", MessageBoxOption.Ok);

            this.CloseModalWindow("DialogEmision");
        }

        partial void GridChequesGiro_Saved()
        {
            ChequesPorCuentaBancoYSituacion.Refresh();
        }
    }
}
