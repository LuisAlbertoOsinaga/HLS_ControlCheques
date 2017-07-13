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
    public partial class GridBeneficiarios
    {
        partial void BeneficiariosOrdenados_Loaded(bool succeeded)
        {
            Mensaje = BeneficiariosOrdenados.Count == 0 ? Globales.MensajeNoHayRegistros : string.Empty;
        }

        partial void GridBeneficiarios_Saved()
        {
            this.Refresh();
        }
    }
}
