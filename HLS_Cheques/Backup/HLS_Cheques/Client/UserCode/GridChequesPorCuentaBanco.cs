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
    public partial class GridChequesPorCuentaBanco
    {
        partial void Cuenta_Changed()
        {
            CuentaMoneda = Cuenta != null ? Cuenta.Moneda : string.Empty;
        }

        partial void ChequesPorCuenta_Loaded(bool succeeded)
        {
            Mensaje = ChequesPorCuenta.Count == 0 ? Globales.MensajeNoHayRegistros : string.Empty; 
        }
    }
}
