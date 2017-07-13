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
    public partial class GridEmails
    {
        partial void EmailsOrdenados_Loaded(bool succeeded)
        {
            Mensaje = EmailsOrdenados.Count == 0 ? Globales.MensajeNoHayRegistros : string.Empty;
        }

        partial void GridEmails_Saved()
        {
            this.Refresh();
        }
    }
}
