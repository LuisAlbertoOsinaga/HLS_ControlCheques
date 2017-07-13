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
    public partial class GridGiradores
    {
        partial void GiradoresOrdenados_Loaded(bool succeeded)
        {
            Mensaje = GiradoresOrdenados.Count == 0 ? Globales.MensajeNoHayRegistros : string.Empty;
        }

        partial void GridGiradores_Saved()
        {
            this.Refresh();
        }
    }
}
