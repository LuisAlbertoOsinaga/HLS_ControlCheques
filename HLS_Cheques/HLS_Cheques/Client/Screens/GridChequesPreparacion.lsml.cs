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
    public partial class GridChequesPreparacion
    {
        partial void ChequesPorCuentaBancoYSituacion_Loaded(bool succeeded)
        {
            Mensaje = ChequesPorCuentaBancoYSituacion.Count == 0 ? Globales.MensajeNoHayRegistros : string.Empty;
        }

        partial void GridChequesPreparacion_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            ChequeSituacion = Globales.SituacionCheque_Preparado;

            IContentItemProxy btnAdd = this.FindControl("gridAddNew");
            btnAdd.IsEnabled = false;
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

        partial void GridChequesPreparacion_Saved()
        {
            ChequesPorCuentaBancoYSituacion.Refresh();
        }
    }
}
