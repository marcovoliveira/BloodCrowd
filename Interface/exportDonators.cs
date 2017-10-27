using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace Interface
{
    // Esta é a classe responsavel por exportar os dados tanto para XML como JSON
    class ExportDonators
    {
        // Este metodo é responsável por decidir que tipo de exportação vai ser utilizada, json ou xml, definindo que utilizadores
        //vai exportar e a lista de donators
        public static bool ExportDonator(List<BloodDonator> donators, int tipo, List<int> posicao)
        {
            if (tipo == 0)
            {
                exportXML(donators, posicao);
            }
            if (tipo == 1)
            {
                exportJSON(donators, posicao);
            }
            if (tipo == 2)
            {
                exportXML(donators, posicao);
                exportJSON(donators, posicao);
            }

            return true;
        }
        //metodo responsável por exportar em xml
        private static bool exportXML(List<BloodDonator> donators, List<int> id)
        {

            String number;
            String sexo;
            String firstName;
            String lastName;
            String streetAddress;
            String city;
            String statefull;
            String zipCode;
            String eMail;
            String userName;
            String password;
            String telephoneNumber;
            String mothersMaiden;
            String birthDay;
            String age;
            String occupation;
            String company;
            String vehicle;
            String bloodType;
            String kilograms;
            String centimeters;
            String guid;
            String latitude;
            String longitude;

            XmlDocument docExportar = new XmlDocument();
            XmlDeclaration decExportar = docExportar.CreateXmlDeclaration("1.0", null, null);
            docExportar.AppendChild(decExportar);
            XmlElement rootExportar = docExportar.CreateElement("DonatorsList"); // Criar um root onde os Elementos Donators irão ser introduzidos
            docExportar.AppendChild(rootExportar);


            /*
             * Aqui é preciso criar um ciclo de forma a poder comparar ID com ID 
             * 
             * 
             * 
             * 
             * 
             * */

            

            for (int i = 0; i < id.Count(); i++)
            {
                foreach (BloodDonator b in donators.Where(n => n.Number == id[i]))
                {
                    number = Convert.ToString(b.Number);
                    sexo = b.Sexo;
                    firstName = b.FirstName;
                    lastName = b.LastName;
                    streetAddress = b.StreetAddress;
                    city = b.City;
                    statefull = b.Statefull;
                    zipCode = b.ZipCode;
                    eMail = b.Email;
                    userName = b.UserName;
                    password = b.Password;
                    telephoneNumber = Convert.ToString(b.TelephoneNumber);
                    mothersMaiden = b.MothersMaiden;
                    birthDay = Convert.ToString(b.BirthDay);
                    age = Convert.ToString(b.Age);
                    occupation = b.Occupation;
                    company = b.Company;
                    vehicle = b.Vehicle;
                    bloodType = b.BloodType;
                    kilograms = Convert.ToString(b.Kilograms);
                    centimeters = Convert.ToString(b.Centimeters);
                    guid = b.Guid;
                    latitude = b.Latitude;
                    longitude = b.Longitude;

                    rootExportar.AppendChild(AddNewDonator.AddDonator
                    (number, sexo, firstName, lastName, streetAddress, city, statefull, zipCode, eMail, userName, password,
                        telephoneNumber, mothersMaiden, birthDay, age, occupation, company, vehicle, bloodType, kilograms, centimeters,
                        guid, latitude, longitude, docExportar

                    ));

                    docExportar.Save(@"DocumentoExportado.xml");

                }

              
            }
            return true;
        }

        private static bool exportJSON(List<BloodDonator> donators, List<int> id)
        {
            String number;
            String sexo;
            String firstName;
            String lastName;
            String streetAddress;
            String city;
            String statefull;
            String zipCode;
            String eMail;
            String userName;
            String password;
            String telephoneNumber;
            String mothersMaiden;
            String birthDay;
            String age;
            String occupation;
            String company;
            String vehicle;
            String bloodType;
            String kilograms;
            String centimeters;
            String guid;
            String latitude;
            String longitude;

            XmlDocument docExportar = new XmlDocument();
           
            
            XmlElement rootExportar = docExportar.CreateElement("DonatorsList"); // Criar um root onde os Elementos Donators irão ser introduzidos
            docExportar.AppendChild(rootExportar);
          


           

            for (int i = 0; i < id.Count(); i++)
            {
                foreach (BloodDonator b in donators.Where(n => n.Number == id[i]))
                {

                    number = Convert.ToString(b.Number);
                    sexo = b.Sexo;
                    firstName = b.FirstName;
                    lastName = b.LastName;
                    streetAddress = b.StreetAddress;
                    city = b.City;
                    statefull = b.Statefull;
                    zipCode = b.ZipCode;
                    eMail = b.Email;
                    userName = b.UserName;
                    password = b.Password;
                    telephoneNumber = Convert.ToString(b.TelephoneNumber);
                    mothersMaiden = b.MothersMaiden;
                    birthDay = Convert.ToString(b.BirthDay);
                    age = Convert.ToString(b.Age);
                    occupation = b.Occupation;
                    company = b.Company;
                    vehicle = b.Vehicle;
                    bloodType = b.BloodType;
                    kilograms = Convert.ToString(b.Kilograms);
                    centimeters = Convert.ToString(b.Centimeters);
                    guid = b.Guid;
                    latitude = b.Latitude;
                    longitude = b.Longitude;

                    rootExportar.AppendChild(AddNewDonator.AddDonator
                    (number, sexo, firstName, lastName, streetAddress, city, statefull, zipCode, eMail, userName,
                        password,
                        telephoneNumber, mothersMaiden, birthDay, age, occupation, company, vehicle, bloodType,
                        kilograms, centimeters,
                        guid, latitude, longitude, docExportar

                    ));
                }

            }
            String jsonText = "";
            jsonText += JsonConvert.SerializeObject(rootExportar);
            File.WriteAllText(@"DocumentoExportado.json", jsonText);

            return true;
        }
    }
}
    

