using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class SendEmail
    {
        public static void SendEmails()
        {
            string mailBodyhtml =
                "<p>If you are reading this email we are experiencing low levels of your blood type.</p>" +
                "<p>Be kind and go to the nearest hospital to make your donation.</p>" +
                "<p></p><p>Blood Donators Project</p>";
                
            var msg = new MailMessage("blooddonatorsproject@gmail.com", "oklahomatmc@gmail.com", "We need your blood!", mailBodyhtml);
            msg.To.Add("oklahomatmc@gmail.com");
            msg.To.Add("marcooliveirapias@gmail.com");
            msg.IsBodyHtml = true;
            var smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.UseDefaultCredentials = true;
            smtpClient.Credentials = credentials();  //Chamar o metodo com as credensiais 
            smtpClient.EnableSsl = true;
            smtpClient.Send(msg);
            
        }


        //Metodo privado para não ser possivel aceder diretamente as credenciais. 
        private static NetworkCredential credentials()
        {
            NetworkCredential credential = new NetworkCredential("blooddonatorsproject@gmail.com", "blooddonatorsproject123");

            return credential; 
        }
    }
}
