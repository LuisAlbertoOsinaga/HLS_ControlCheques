using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class CuentaBanco
    {
        partial void Identidad_Compute(ref string result)
        {
            result = Banco.Sigla + "-" + CuentaNro + "-" + Moneda;
        }
    }
}
