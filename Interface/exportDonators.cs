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
        public static bool ExportDonator(List<BloodDonator> donators, int tipo, int[] posicao)
        {
            if (tipo == 0)
            {
                exportXML(donators, posicao);
            }
            if (tipo == 1)
            {
                exportJSON(donators, posicao);
            }

            return true;
        }
        //metodo responsável por exportar em xml
        public static bool exportXML(List<BloodDonator> donators, int[] posicao)
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
          




            for (int i = 0; i < posicao.Count(); i++)
            {
                int p = posicao[i] - 1;
                number = Convert.ToString(donators[p].Number);
                sexo = donators[p].Sexo;
                firstName = donators[p].FirstName;
                lastName = donators[p].LastName;
                streetAddress = donators[p].StreetAddress;
                city = donators[p].City;
                statefull = donators[p].Statefull;
                zipCode = donators[p].ZipCode;
                eMail = donators[p].Email;
                userName = donators[p].UserName;
                password = donators[p].Password;
                telephoneNumber = Convert.ToString(donators[p].TelephoneNumber);
                mothersMaiden = donators[p].MothersMaiden;
                birthDay = Convert.ToString(donators[p].BirthDay);
                age = Convert.ToString(donators[p].Age);
                occupation = donators[p].Occupation;
                company = donators[p].Company;
                vehicle = donators[p].Vehicle;
                bloodType = donators[p].BloodType;
                kilograms = Convert.ToString(donators[p].Kilograms);
                centimeters = Convert.ToString(donators[p].Centimeters);
                guid = donators[p].Guid;
                latitude = donators[p].Latitude;
                longitude = donators[p].Longitude;

                rootExportar.AppendChild(AddNewDonator.AddDonator
                    (number, sexo, firstName, lastName, streetAddress, city, statefull, zipCode, eMail, userName, password,
                    telephoneNumber, mothersMaiden, birthDay, age, occupation, company, vehicle, bloodType, kilograms, centimeters,
                    guid, latitude, longitude, docExportar

                    ));
               
                docExportar.Save(@"DocumentoExportado.xml");

            }







            return true;
        }

        public static bool exportJSON(List<BloodDonator> donators, int[] posicao)
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
          


            String jsonText="";

            for (int i = 0; i < posicao.Count(); i++)
            {
                int p = posicao[i] - 1;
                number = Convert.ToString(donators[p].Number);
                sexo = donators[p].Sexo;
                firstName = donators[p].FirstName;
                lastName = donators[p].LastName;
                streetAddress = donators[p].StreetAddress;
                city = donators[p].City;
                statefull = donators[p].Statefull;
                zipCode = donators[p].ZipCode;
                eMail = donators[p].Email;
                userName = donators[p].UserName;
                password = donators[p].Password;
                telephoneNumber = Convert.ToString(donators[p].TelephoneNumber);
                mothersMaiden = donators[p].MothersMaiden;
                birthDay = Convert.ToString(donators[p].BirthDay);
                age = Convert.ToString(donators[p].Age);
                occupation = donators[p].Occupation;
                company = donators[p].Company;
                vehicle = donators[p].Vehicle;
                bloodType = donators[p].BloodType;
                kilograms = Convert.ToString(donators[p].Kilograms);
                centimeters = Convert.ToString(donators[p].Centimeters);
                guid = donators[p].Guid;
                latitude = donators[p].Latitude;
                longitude = donators[p].Longitude;

                rootExportar.AppendChild(AddNewDonator.AddDonator
                    (number, sexo, firstName, lastName, streetAddress, city, statefull, zipCode, eMail, userName, password,
                    telephoneNumber, mothersMaiden, birthDay, age, occupation, company, vehicle, bloodType, kilograms, centimeters,
                    guid, latitude, longitude, docExportar

                    ));
                
            }
            jsonText += JsonConvert.SerializeObject(rootExportar);
            File.WriteAllText(@"DocumentoExportado.json", jsonText);

            return true;
        }
    }
}
    

