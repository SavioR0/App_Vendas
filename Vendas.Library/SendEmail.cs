using System;
using System.Net;
using System.Net.Mail;

namespace Vendas.Library
{
    public class SendEmail
    {
        public static string SendEmailClient(string receiver, string sender, string username, string cpf, string assunto)
        {
            try
            {
                //cria uma mensagem
                //MailMessage messageemai1l = new MailMessage(receiver, "compras_vendass@outlook.com", destinatario, assunto, enviamensagem);

                //StringBuilder body = new StringBuilder();
                //body.Append("<html>");
                //body.Append("<body style=\"font-family:arial, helvetica, sans-serif; font-size: 14px\">");
                //body.Append("<table>");
                //body.Append("<tr>");
                //body.Append("<td style=\"font-family:arial, helvetica, sans-serif; font-size: 12px; font-weight: bold; background-color: #cedeeb; border: 1px solid #000080;vertical-align: top; text-align: center;\">contato1</td>");
                //body.Append("<td style=\"font-family:arial, helvetica, sans-serif; font-size: 12px; font-weight: bold; background-color: #cedeeb; border: 1px solid #000080;vertical-align: top; text-align: center;\">compra_vendass</td>");
                //body.Append("</tr>");

                //body.Append("<tr>");
                //body.Append("<td style=\"font-family:arial, helvetica, sans-serif; font-size: 12px; font-weight: bold; background-color: #bdcdda; border: 1px solid #000080;vertical-align: top; text-align: center;\">contato2</td>");
                //body.Append("<td style=\"font-family:arial, helvetica, sans-serif; font-size: 12px; font-weight: bold; background-color: #bdcdda; border: 1px solid #000080;vertical-align: top; text-align: center;\">fercondini</td>");
                //body.Append("</tr>");

                //body.Append($"<td style=\"font-family:arial, helvetica, sans-serif; font-size: 12px; font-weight: bold; background-color: #bdcdda; border: 1px solid #000080;vertical-align: top; text-align: center;\"><br/> olá, a seguir têm-se as informações de login: \n\tusername: {username} senha: {cpf}");
                //body.Append("<\\html>");

                string body = $"Olá,\n a seguir têm-se as informações de login: \n\n\t -Usuário: {username} \n\n\t -Senha: {cpf}";
                MailMessage messageEmail = new MailMessage(sender, receiver, "Login sistema de Compra e Venda", body); 
                var smtp = new SmtpClient();
                {
                    smtp.Host = "smtp.office365.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(sender, "App012qwertyuiop");
                    smtp.Timeout = 20000;
                }
                // envia a mensagem
                smtp.Send(messageEmail);

                return "Mensagem enviada para  " + receiver + " às " + DateTime.Now.ToString() + ".";
            }
            catch (Exception ex)
            {
                string erro = ex.InnerException.ToString();
                return ex.Message.ToString() + erro;
            }
        
        }
    }
}
