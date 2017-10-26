using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    class SendEmail
    {
        public static bool BloodTypeEmail(List<String>  bloodtype)
        {

            List<BloodDonator> donators = new List<BloodDonator>();


            donators = CreateListDonators.ListDonators();

            try
            {

                if (bloodtype.Contains("A+"))
                {
                    var listAMore = donators.Where(item => item.BloodType == "A+");

                    foreach (var a in listAMore)
                    {
                        SendEmails(a.Email, "A+");
                    }
                }

                if (bloodtype.Contains("A-"))
                {
                    var listALess = donators.Where(item => item.BloodType == "A-");

                    foreach (var a in listALess)
                    {
                        SendEmails(a.Email, "A-");
                    }
                }

                if (bloodtype.Contains("B+"))
                {
                    var listBMore = donators.Where(item => item.BloodType == "B+");

                    foreach (var a in listBMore)
                    {
                        SendEmails(a.Email, "B+");
                    }
                }
                if (bloodtype.Contains("B-"))
                {
                    var listBLess = donators.Where(item => item.BloodType == "B-");

                    foreach (var a in listBLess)
                    {
                        SendEmails(a.Email, "B-");
                    }
                }
                if (bloodtype.Contains("AB+"))
                {
                    var listABMore = donators.Where(item => item.BloodType == "AB+");

                    foreach (var a in listABMore)
                    {
                        SendEmails(a.Email, "AB+");
                    }
                }
                if (bloodtype.Contains("AB-"))
                {
                    var listABLess = donators.Where(item => item.BloodType == "AB-");

                    foreach (var a in listABLess)
                    {
                        SendEmails(a.Email, "AB-");
                    }
                }
                if (bloodtype.Contains("O+"))
                {
                    var listOMore = donators.Where(item => item.BloodType == "O+");

                    foreach (var a in listOMore)
                    {
                        SendEmails(a.Email, "O+");
                    }
                }
                if (bloodtype.Contains("O-"))
                {
                    var listOLess = donators.Where(item => item.BloodType == "O-");

                    foreach (var a in listOLess)
                    {
                        SendEmails(a.Email, "O-");
                    }
                }

                return true; 

            }
            catch (Exception e)
            {
                return false; 
            }
        }

        private static void SendEmails(string email, string bloodtype)
        {
            try
            {
                string mailBodyhtml =
                    "<p>If you are reading this email we are experiencing low levels of " + bloodtype +
                    ", your blood type.</p>" +
                    "<p>Be kind and go to the nearest hospital to make your donation.</p>" +
                    "<p></p><p>Blood Donators Project</p>";

                var msg = new MailMessage("blooddonatorsproject@gmail.com", email, "We need your blood!", mailBodyhtml);
                msg.To.Add(email);
                msg.IsBodyHtml = true;
                // substituir erro por smtp
                var smtpClient = new SmtpClient("erro.gmail.com", 587);
                smtpClient.UseDefaultCredentials = true;
                smtpClient.Credentials = Credentials(); //Chamar o metodo com as credensiais 
                smtpClient.EnableSsl = true;
                smtpClient.Send(msg);
            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
            }
        }


        //Metodo privado para não ser possivel aceder diretamente as credenciais. 
        private static NetworkCredential Credentials()
        {
            NetworkCredential credential = new NetworkCredential("blooddonatorsproject@gmail.com", "blooddonatorsproject123");

            return credential; 
        }
    }
}
