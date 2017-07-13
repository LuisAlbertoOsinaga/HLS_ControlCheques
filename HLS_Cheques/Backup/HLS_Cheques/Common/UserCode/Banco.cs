using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Banco
    {
        partial void Nombre_Changed()
        {
            if (!string.IsNullOrEmpty(Nombre))
                Nombre = Nombre.Trim().ToUpper();
        }

        partial void Sigla_Changed()
        {
            if (!string.IsNullOrEmpty(Sigla))
                Sigla = Sigla.Trim().ToUpper();
        }
    }
}
