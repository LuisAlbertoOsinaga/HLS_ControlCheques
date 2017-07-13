using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Net;
using System.Net.Mail;
using System.Configuration;

namespace LightSwitchApplication.UserCode
{
    public static class ServiceMail
    {
        public static void SendMail(string sendFrom, string sendTo, string subject, string body)
        {
            MailAddress fromAddress = new MailAddress(sendFrom);
            MailAddress toAddress = new MailAddress(sendTo);
            MailMessage mail = new MailMessage();
            mail.From = fromAddress;
            mail.To.Add(toAddress);
            mail.Subject = subject;
            if (body.ToLower().Contains("<html>"))
            {
                mail.IsBodyHtml = true;
            }
            mail.Body = body;
            // SmtpClient smtp = new SmtpClient(Globales.SMTPServer, Globales.SMTPPort);
            SmtpClient smtp = new SmtpClient(Globales.SMTPServer);
            if (Globales.SMTPEnableSsl == "S")
                smtp.EnableSsl = true;
            if (Globales.SMTPDeliveryMethod == "Network")
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            //add credentials here if required
            smtp.Credentials = new NetworkCredential(Globales.SMTPUserId, Globales.SMTPPassword);
            smtp.Send(mail);
        }
    }
}