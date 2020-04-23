using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Email
{
    public class ContatoEmail
    {
        public static void EnviarContatoPorEmail(Contato pContato)
        {
            /*
             * SMTP - Servidor que Envia a Mensagem
             */
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("brunoangeoletto@gmail.com", "");
            smtp.EnableSsl = true;

            string corpoMsg = string.Format("<h2>Contato  - Loja Virtual</h2>" +
                "<b>Nome: </b>{0} </b>" +
                "<b>E-Mail: </b>{1} </b>" +
                "<b>Texto: </b>{3} </b>" +
                "</b> E-Mail Enviado Automaticamente do site Loja Virtual",
                pContato.Nome, pContato.Email, pContato.Texto);

            //MailMensage = Contruir a mensagem pra ser enviada
            MailMessage mensagem = new MailMessage();

            mensagem.From = new MailAddress("brunoangeoletto@gmail.com");
            mensagem.To.Add(new MailAddress("brunoangeoletto@gmail.com"));
            mensagem.Subject = "Contato - Loja Virtual - E-Mail: " + pContato.Email;
            mensagem.Body = corpoMsg;
            mensagem.IsBodyHtml = true;

            smtp.Send(mensagem);
        }
    }
}
