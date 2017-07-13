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
    public partial class GridChequesSituaciones
    {
        partial void ChequesPorCuentaBanco_Loaded(bool succeeded)
        {
            Mensaje = ChequesPorCuentaBanco.Count == 0 ? Globales.MensajeNoHayRegistros : string.Empty;
        }

        partial void CuentaBanco_Changed()
        {
            Moneda = CuentaBanco != null ? CuentaBanco.Moneda : string.Empty;
            ChequesPorCuentaBanco.Load();
        }

        partial void CancelaAnulacion_Execute()
        {
            this.DataWorkspace.ApplicationData.Details.DiscardChanges();
            this.CloseModalWindow("DialogAnulacion");
        }

        partial void ConfirmaAnulacion_Execute()
        {
            Cheque chq = ChequesPorCuentaBanco.SelectedItem;

            if (!chq.FechaAnulación.HasValue || chq.FechaAnulación < new DateTime(2000, 1, 1))
            {
                this.ShowMessageBox("Fecha de anulación inválida!");
                return;
            }
            if(string.IsNullOrEmpty(Motivo))
            {
                this.ShowMessageBox("Motivo de la anulación en blanco!");
                return;
            }

            // Cambios
            chq.Observacion += "| ANULADO POR: " + Motivo + " | " + "*** " + chq.Situacion + " *** |";
            chq.Situacion = Globales.SituacionCheque_Anulado;
            chq.UsuarioAnulacion = Application.User.FullName;

            // Salva Cheques
            this.DataWorkspace.ApplicationData.SaveChanges();
            ChequesPorCuentaBanco.Refresh();

            // Mensaje de exito
            this.ShowMessageBox("Anulación de Cheque realizada!", " ", MessageBoxOption.Ok);

            this.CloseModalWindow("DialogAnulacion");
        }

        partial void AnulaCheque_Execute()
        {
            if (ChequesPorCuentaBanco.SelectedItem != null)
            {
                if (ChequesPorCuentaBanco.SelectedItem.Situacion != Globales.SituacionCheque_Anulado)
                    this.OpenModalWindow("DialogAnulacion");
                else
                    this.ShowMessageBox("Cheque ya está anulado!");
            }
        }

        partial void GridChequesSituaciones_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            IContentItemProxy btnAnulaCheque = this.FindControl("AnulaCheque");
            btnAnulaCheque.IsEnabled = false;
        }

        partial void ChequesPorCuentaBanco_Changed(NotifyCollectionChangedEventArgs e)
        {
            IContentItemProxy btnAnulaCheque = this.FindControl("AnulaCheque");
            if (ChequesPorCuentaBanco.SelectedItem != null)
            {
                btnAnulaCheque.IsEnabled = true;
            }
            else
            {
                btnAnulaCheque.IsEnabled = false;
            }
        }

        partial void RevertirAnulacion_Execute()
        {
            if (ChequesPorCuentaBanco.SelectedItem != null)
            {
                if (ChequesPorCuentaBanco.SelectedItem.Situacion == Globales.SituacionCheque_Anulado)
                    this.OpenModalWindow("DialogReversionAnulacion");
                else
                    this.ShowMessageBox("Cheque no está anulado!");
            }
        }

        partial void CancelaReversionAnulacion_Execute()
        {
            this.DataWorkspace.ApplicationData.Details.DiscardChanges();
            this.CloseModalWindow("DialogReversionAnulacion");
        }

        partial void ConfirmaReversionAnulacion_Execute()
        {
            Cheque chq = ChequesPorCuentaBanco.SelectedItem;

            // Cambios
            int indexToSituacion = chq.Observacion.IndexOf(" | *** ");
            string situacion = indexToSituacion > 0 ? chq.Observacion.Substring(indexToSituacion + 7, 1) : string.Empty;
            if(situacion != string.Empty)
                chq.Situacion = situacion;

            // Salva Cheques
            this.DataWorkspace.ApplicationData.SaveChanges();
            ChequesPorCuentaBanco.Refresh();

            // Mensaje de exito
            this.ShowMessageBox("Reversión de Anulación de Cheque realizada!", " ", MessageBoxOption.Ok);

            this.CloseModalWindow("DialogReversionAnulacion");
        }
    }
}
