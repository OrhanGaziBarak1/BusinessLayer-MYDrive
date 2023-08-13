using BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class EmailSender : IEmailSender
    {
        public Task SendMailAsync(string email, string subject, string message)
        {
            var smtp = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("barakorhangazi4.5@gmail.com", "aykxdmjfwwpzvgvt")
            };

            return smtp.SendMailAsync(new MailMessage(from: "barakorhangazi4.5@gmail.com",
                to: email,
                subject,
                message
                ));
        }
    }
}
