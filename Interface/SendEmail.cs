using Interface.ServiceReference1;
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

            Service1Client client = new Service1Client();
            
            try
            {

                if (bloodtype.Contains("A+"))
                {
                    var listAMore = client.ListaDonators().Where(item => item.BloodType.Equals("A+"));
                    

                    foreach (var a in listAMore)
                    {
                       
                        client.SendEmails(a.EMail, "A+");
                    }
                }

                if (bloodtype.Contains("A-"))
                {
                    var listALess = client.ListaDonators().Where(item => item.BloodType == "A-");

                    foreach (var a in listALess)
                    {
                        client.SendEmails(a.EMail, "A-");
                    }
                }

                if (bloodtype.Contains("B+"))
                {
                    var listBMore = client.ListaDonators().Where(item => item.BloodType == "B+");

                    foreach (var a in listBMore)
                    {
                        client.SendEmails(a.EMail, "B+");
                    }
                }
                if (bloodtype.Contains("B-"))
                {
                    var listBLess = client.ListaDonators().Where(item => item.BloodType == "B-");

                    foreach (var a in listBLess)
                    {
                        client.SendEmails(a.EMail, "B-");
                    }
                }
                if (bloodtype.Contains("AB+"))
                {
                    var listABMore = client.ListaDonators().Where(item => item.BloodType == "AB+");

                    foreach (var a in listABMore)
                    {
                        client.SendEmails(a.EMail, "AB+");
                    }
                }
                if (bloodtype.Contains("AB-"))
                {
                    var listABLess = client.ListaDonators().Where(item => item.BloodType == "AB-");

                    foreach (var a in listABLess)
                    {
                        client.SendEmails(a.EMail, "AB-");
                    }
                }
                if (bloodtype.Contains("O+"))
                {
                    var listOMore = client.ListaDonators().Where(item => item.BloodType == "O+");

                    foreach (var a in listOMore)
                    {
                        client.SendEmails(a.EMail, "O+");
                    }
                }
                if (bloodtype.Contains("O-"))
                {
                    var listOLess = client.ListaDonators().Where(item => item.BloodType == "O-");

                    foreach (var a in listOLess)
                    {
                        client.SendEmails(a.EMail, "O-");
                    }
                }

                return true; 

            }
            catch (Exception e)
            {
                return false; 
            }
        }

       
       
    }
}
