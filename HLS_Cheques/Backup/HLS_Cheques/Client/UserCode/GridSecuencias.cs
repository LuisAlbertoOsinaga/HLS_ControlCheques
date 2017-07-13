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
    public partial class GridSecuencias
    {
        partial void SecuenciasOrdenadas_Loaded(bool succeeded)
        {
            Mensaje = SecuenciasOrdenadas.Count == 0 ? Globales.MensajeNoHayRegistros : string.Empty;
        }

        partial void GridSecuencias_Saved()
        {
            this.Refresh();
        }
    }
}
