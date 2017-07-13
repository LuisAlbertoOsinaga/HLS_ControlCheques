using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Beneficiario
    {
        partial void Nombre_Changed()
        {
            if (!string.IsNullOrEmpty(Nombre))
            {
                Nombre = Nombre.Trim().ToUpper();
            }
        }
    }
}
