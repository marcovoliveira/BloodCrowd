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
        public static void BloodTypeEmail(int bloodtype)
        {

            List<BloodDonator> donators = new List<BloodDonator>();


            donators = CreateListDonators.ListDonators();

            

            if (bloodtype == 1)
            {
                var listAMore = donators.Where(item => item.BloodType == "A+");

                foreach (var a in listAMore)
                {
                     SendEmails(a.Email, "A+");
                }
            }

            if (bloodtype == 1)
            {
                var listALess = donators.Where(item => item.BloodType == "A-");

                foreach (var a in listALess)
                {
                    SendEmails(a.Email, "A-");
                }
            }

            if (bloodtype == 1)
            {
                var listBMore = donators.Where(item => item.BloodType == "B+");

                foreach (var a in listBMore)
                {
                    SendEmails(a.Email, "B+");
                }
            }
        }

        public static void SendEmails(string email, string bloodtype)
        {
            string mailBodyhtml =
                "<p>If you are reading this email we are experiencing low levels of "+ bloodtype +", your blood type.</p>" +
                "<p>Be kind and go to the nearest hospital to make your donation.</p>" +
                "<p></p><p>Blood Donators Project</p>";
                
            var msg = new MailMessage("blooddonatorsproject@gmail.com", email, "We need your blood!", mailBodyhtml);
            msg.To.Add(email);
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
