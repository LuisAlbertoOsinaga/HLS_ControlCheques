using System;
using System.Linq;

namespace LightSwitchApplication.UserCode
{
    public static class ServicioMail
    {
        public static void SendEMail(string from, string to, string subject, string body)
        {
            using(DataWorkspace tempWS = new DataWorkspace())
            {
                OperacionEMail newOpEmail = tempWS.ApplicationData.OperacionEMails.AddNew();
                newOpEmail.Enviante = from;
                newOpEmail.Destinatario = to;
                newOpEmail.Asunto = subject;
                newOpEmail.Cuerpo = body;

                tempWS.ApplicationData.SaveChanges();
            }
        
        }


        public static void SendMailSolicitudCheques(string mensaje)
        {
            using (DataWorkspace tempWS = new DataWorkspace())
            {
                Email[] emails = (from Email em in tempWS.ApplicationData.Emails
                                  where em.RolMail == Globales.SolicitudChequeRolMail
                                  select em).ToArray();

                Parametro[] parms = (from Parametro p in tempWS.ApplicationData.Parametros
                                     where p.Categoria == Globales.CategoriaSmtpMail &&
                                             p.Clave == Globales.ClaveSmtpMail
                                     select p).ToArray();

                string smtpFrom = parms != null && parms.Length > 0 ? parms[0].Valor : Globales.SMTPFrom;


                foreach (Email email in emails)
                {
                    OperacionEMail newOpEmail = tempWS.ApplicationData.OperacionEMails.AddNew();
                    newOpEmail.Enviante = smtpFrom;
                    newOpEmail.Destinatario = email.Mail;
                    newOpEmail.Asunto = Globales.SolicitudChequeAsuntoMail;
                    newOpEmail.Cuerpo = mensaje;
                }

                tempWS.ApplicationData.SaveChanges();
            }
        }
    }
}
