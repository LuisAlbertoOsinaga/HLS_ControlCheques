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
    public partial class GridChequesCobradosRevision
    {
        partial void GridChequesCobradosRevision_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            ChequeSituacion = Globales.SituacionCheque_Cobrado;
        }

        partial void ChequesPorCuentaBancoYSituacion_Loaded(bool succeeded)
        {
            Mensaje = ChequesPorCuentaBancoYSituacion.Count == 0 ? Globales.MensajeNoHayRegistros : string.Empty;
        }

        partial void Cuenta_Changed()
        {
            Moneda = Cuenta != null ? Cuenta.Moneda : string.Empty;
            ChequesPorCuentaBancoYSituacion.Load();
        }

        partial void RevertirCobro_Execute()
        {
            if (ChequesPorCuentaBancoYSituacion.SelectedItem != null)
                this.OpenModalWindow("DialogReversion");
        }

        partial void CancelarReversion_Execute()
        {
            DataWorkspace.ApplicationData.Details.DiscardChanges();
            this.CloseModalWindow("DialogReversion");
        }

        partial void ConfirmarReversion_Execute()
        {
            Cheque chq = this.ChequesPorCuentaBancoYSituacion.SelectedItem;
            chq.Situacion = Globales.SituacionCheque_Emitido;
            this.ChequesPorCuentaBancoYSituacion.SelectedItem.UsuarioPago = null;
            this.ChequesPorCuentaBancoYSituacion.SelectedItem.FechaPago = null;

            Save();
            this.ChequesPorCuentaBancoYSituacion.Refresh();

            this.CloseModalWindow("DialogReversion");
        }

        partial void DespliegaImgCheque_Execute()
        {
            if (ChequesPorCuentaBancoYSituacion.SelectedItem != null)
                this.OpenModalWindow("DialogImgCheque");
        }

        partial void DespliegaImgFactura_Execute()
        {
            if (ChequesPorCuentaBancoYSituacion.SelectedItem != null)
                this.OpenModalWindow("DialogImgFactura");
        }

        partial void DespliegaImgCbte_Execute()
        {
            if (ChequesPorCuentaBancoYSituacion.SelectedItem != null)
                this.OpenModalWindow("DialogImgCbte");
        }

        partial void DespliegaImgDocs_Execute()
        {
            if (ChequesPorCuentaBancoYSituacion.SelectedItem != null)
                this.OpenModalWindow("DialogImgDocs");
        }
    }
}
