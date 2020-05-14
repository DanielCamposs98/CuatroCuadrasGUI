using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

namespace Persistencia.ServiciosMail
{
    public abstract class ServidorMail
    {

        //Atributos
        private SmtpClient smtpClient;
        protected string remitente { get; set; }
        protected string contrasena { get; set; }
        protected string host { get; set; }
        protected int puerto { get; set; }
        protected bool ssl { get; set; }

        //Inicializar propiedades del cliente SMTP
        protected void initializeSmtpClient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(remitente, contrasena);
            smtpClient.Host = host;
            smtpClient.Port = puerto;
            smtpClient.EnableSsl = ssl;
        }
        public void sendMail(string subject, string body, List<string> recipientMail)
        {
            var mailMessage = new MailMessage();
            try
            {
                mailMessage.From = new MailAddress(remitente);
                foreach (string mail in recipientMail)
                {
                    mailMessage.To.Add(mail);
                }
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.Priority = MailPriority.Normal;
                smtpClient.Send(mailMessage);
            }
            catch (Exception) { }
            finally
            {
                mailMessage.Dispose();
                smtpClient.Dispose();
            }
        }
    }
}


