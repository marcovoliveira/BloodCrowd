using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Interface
{
    class AddNewDonator
    {
        public static XmlElement AddDonator(String number, String sexo, String firstName, String lastName, String streetAddress,
    String city, String statefull, String zipCode, String eMail, String userName, String password, String telephoneNumber,
    String mothersMaiden, String birthDay, String age, String occupation, String company, String vehicle, String bloodType,
    String kilograms, String centimeters, String guid, String latitude, String longitude, XmlDocument doc)
        {
            XmlElement Donator = doc.CreateElement("Donator");
            
            return Donator;
        }
    }
}
