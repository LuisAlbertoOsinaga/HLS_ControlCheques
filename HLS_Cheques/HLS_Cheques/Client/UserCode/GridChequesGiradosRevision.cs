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

using LightSwitchApplication.UserCode;
using System.Collections.Specialized;

namespace LightSwitchApplication
{
    public partial class GridChequesGiradosRevision
    {
        partial void ChequesPorCuentaBancoYSituacion_Loaded(bool succeeded)
        {
            Mensaje = Cuenta != null && ChequesPorCuentaBancoYSituacion.Count == 0 ? Globales.MensajeNoHayRegistros : string.Empty;
        }

        partial void Cuenta_Changed()
        {
            Moneda = Cuenta != null ? Cuenta.Moneda : string.Empty;
            ChequesPorCuentaBancoYSituacion.Load();
        }

        partial void GridChequesGiradosRevision_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            ChequeSituacion = Globales.SituacionCheque_Emitido;

            IContentItemProxy btnCheque = this.FindControl("btnCheque");
            btnCheque.IsEnabled = false;
            IContentItemProxy btnCbte = this.FindControl("btnCbte");
            btnCbte.IsEnabled = false;
            IContentItemProxy btnFact = this.FindControl("btnFact");
            btnFact.IsEnabled = false;
            IContentItemProxy btnDocs = this.FindControl("btnDocs");
            btnDocs.IsEnabled = false;

            IContentItemProxy btnRevertir = this.FindControl("btnRevertir");
            btnRevertir.IsEnabled = false;
        }

        partial void Cheque_Execute()
        {
            if (ChequesPorCuentaBancoYSituacion.SelectedItem != null)
                this.OpenModalWindow("DialogCheque");
        }

        partial void Cbte_Execute()
        {
            if (ChequesPorCuentaBancoYSituacion.SelectedItem != null)
                this.OpenModalWindow("DialogCbte");
        }

        partial void Fact_Execute()
        {
            if (ChequesPorCuentaBancoYSituacion.SelectedItem != null)
                this.OpenModalWindow("DialogFact");
        }

        partial void Docs_Execute()
        {
            if (ChequesPorCuentaBancoYSituacion.SelectedItem != null)
                this.OpenModalWindow("DialogDocs");
        }

        partial void Revertir_Execute()
        {
            if (ChequesPorCuentaBancoYSituacion.SelectedItem != null)
                this.OpenModalWindow("DialogRevertir");
        }

        partial void CancelarReversion_Execute()
        {
            this.CloseModalWindow("DialogRevertir");
        }

        partial void ConfirmarReversion_Execute()
        {
            this.ChequesPorCuentaBancoYSituacion.SelectedItem.Situacion = Globales.SituacionCheque_Solicitado;
            this.ChequesPorCuentaBancoYSituacion.SelectedItem.UsuarioEmision = null;
            this.ChequesPorCuentaBancoYSituacion.SelectedItem.FechaEmision = null;
            this.ChequesPorCuentaBancoYSituacion.SelectedItem.Girador = null;
            this.ChequesPorCuentaBancoYSituacion.SelectedItem.FechaGiro = null;

            Save();
            this.ChequesPorCuentaBancoYSituacion.Refresh();

            this.CloseModalWindow("DialogRevertir");
        }

        partial void ChequesPorCuentaBancoYSituacion_Changed(NotifyCollectionChangedEventArgs e)
        {
            IContentItemProxy btnCheque = this.FindControl("btnCheque");
            IContentItemProxy btnCbte = this.FindControl("btnCbte");
            IContentItemProxy btnFact = this.FindControl("btnFact");
            IContentItemProxy btnDocs = this.FindControl("btnDocs");
            IContentItemProxy btnRevertir = this.FindControl("btnRevertir");
            if (ChequesPorCuentaBancoYSituacion.SelectedItem != null)
            {
                btnCheque.IsEnabled = true;
                btnCbte.IsEnabled = true;
                btnFact.IsEnabled = true;
                btnDocs.IsEnabled = true;

                btnRevertir.IsEnabled = true;
            }
            else
            {
                btnCheque.IsEnabled = false;
                btnCbte.IsEnabled = false;
                btnFact.IsEnabled = false;
                btnDocs.IsEnabled = false;

                btnRevertir.IsEnabled = false;
            }
        }
    }
}
