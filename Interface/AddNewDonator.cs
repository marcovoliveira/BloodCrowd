using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Interface
{
    class AddNewDonator
    {
        public static XmlElement AddDonator(int number, String sexo, String firstName, String lastName, String streetAddress,
    String city, String statefull, String zipCode, String eMail, String userName, String password, long telephoneNumber,
    String mothersMaiden, DateTime birthDay, int age, String occupation, String company, String vehicle, String bloodType,
    float kilograms, float centimeters, String guid, double latitude, double longitude, XmlDocument doc)
        {
            XmlElement Donator = doc.CreateElement("Donator");

            return Donator;
        }
    }
}
