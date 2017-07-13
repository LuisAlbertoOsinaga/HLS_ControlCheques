using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Email
    {
        partial void DestinatarioMail_Compute(ref string result)
        {
            result = "<" + Destinatario + ">" + Mail;
        }

        partial void Destinatario_Changed()
        {
            if (!string.IsNullOrEmpty(Destinatario))
                Destinatario = Destinatario.Trim().ToUpper();
        }

        partial void Mail_Changed()
        {
            if (!string.IsNullOrEmpty(Mail))
                Mail = Mail.Trim().ToLower();
        }

        partial void RolMail_Changed()
        {
            if (!string.IsNullOrEmpty(RolMail))
                RolMail = RolMail.Trim().ToUpper();
        }
    }
}
