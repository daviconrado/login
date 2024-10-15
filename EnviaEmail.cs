using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SistemaLogin
{
    internal class EnviaEmail
    {
        public static void SendEmail(string email, int codigo)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential("enviaemaillogin@gmail.com", "ejdq jnti vzjf ewpo");
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

                MailMessage message = new MailMessage();
                message.From = new MailAddress("enviaemaillogin@gmail.com");
                message.To.Add(new MailAddress(email));
                message.Subject = "Código de verificação";
                message.Body = $"O seu código de verificação é: {codigo}";
                message.IsBodyHtml = false;

                smtpClient.Send(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
