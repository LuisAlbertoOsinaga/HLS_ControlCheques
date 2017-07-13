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

namespace LightSwitchApplication
{
    public partial class GridChequesCobro
    {
        partial void GridChequesCobro_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            ChequeSituacion = Globales.SituacionCheque_Emitido;
        }

        partial void Cuenta_Changed()
        {
            Moneda = Cuenta != null ? Cuenta.Moneda : string.Empty;
            ChequesPorCuentaBancoYSituacion.Load();
        }

        partial void ChequesPorCuentaBancoYSituacion_Loaded(bool succeeded)
        {
            Mensaje = Cuenta != null && ChequesPorCuentaBancoYSituacion.Count == 0 ? Globales.MensajeNoHayRegistros : string.Empty;
        }

        partial void CobroCheque_Execute()
        {
            if (ChequesPorCuentaBancoYSituacion.SelectedItem != null)
                this.OpenModalWindow("DialogCobro");
        }

        partial void CancelarCobro_Execute()
        {
            this.DataWorkspace.ApplicationData.Details.DiscardChanges();
            this.CloseModalWindow("DialogCobro");
        }

        partial void ConfirmarCobro_Execute()
        {
            Cheque chq = ChequesPorCuentaBancoYSituacion.SelectedItem;

            if (!chq.FechaPago.HasValue || chq.FechaPago < new DateTime(2000, 1, 1))
            {
                this.ShowMessageBox("Fecha de cobro inválida!");
                return;
            }

            // Cambios
            chq.Situacion = Globales.SituacionCheque_Cobrado;
            chq.UsuarioPago = Application.User.FullName;

            // Salva Cheques
            this.DataWorkspace.ApplicationData.SaveChanges();
            ChequesPorCuentaBancoYSituacion.Refresh();

            // Mensaje de exito
            this.ShowMessageBox("Cobro de cheque registrado!", " ", MessageBoxOption.Ok);

            this.CloseModalWindow("DialogCobro");
        }

        partial void GridChequesCobro_Saved()
        {
            ChequesPorCuentaBancoYSituacion.Refresh();
        }
    }
}
