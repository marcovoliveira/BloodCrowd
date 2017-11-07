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
            string caminho;
            string caminho2;


            if (tipo == 0)
            {
                 caminho = Path("ExportDocumentXML.xml", "XML|*.xml");

                if (caminho != null)
                {
                    if (exportXML(donators, posicao, caminho)) // Metodo ExportXML devolve um bool 
                    {
                        MessageBox.Show("Donators successfully exported to XML!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to export to XML!");
                    }
                }

            }
            if (tipo == 1)
            {
                caminho = Path("ExportDocumentJson.json", "JSON|*.json");

                if (caminho != null)
                {
                    if (exportJSON(donators, posicao, caminho))
                    {
                        MessageBox.Show("Donators successfully exported to Json!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to export to Json!");
                    }
                }
               
            }
            if (tipo == 2)
            {
                caminho = Path("ExportDocumentXML.xml", "XML|*.xml");
                caminho2 = Path("ExportDocumentJson.json", "JSON|*.json");

                if (caminho != null && caminho2 == null)
                {
                    if (exportXML(donators, posicao, caminho))
                    {
                        MessageBox.Show("Donators successfully exported to XML");
                    }
                    else
                    {
                        MessageBox.Show("Failed to export to XML");
                    }
                }

                if (caminho == null && caminho2 != null)
                {
                    if (exportJSON(donators, posicao, caminho2))
                    {
                        MessageBox.Show("Donators successfully exported to Json");
                    }
                    else
                    {
                        MessageBox.Show("Failed to export to Json");
                    }
                }

                if (caminho != null && caminho2 != null)
                {
                    if (exportXML(donators, posicao, caminho) && exportJSON(donators, posicao, caminho2))
                    {
                        MessageBox.Show("Donators successfully exported to XML & Json");
                    }
                    else
                    {
                        MessageBox.Show("Failed to export to XML & Json");
                    }
                }


            }

            return true;
        }
        //metodo responsável por exportar em xml
        private static bool exportXML(List<BloodDonator> donators, List<int> id, string path)
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

                    docExportar.Save(path);

                }

              
            }
            return true;
        }

        private static bool exportJSON(List<BloodDonator> donators, List<int> id, string path)
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
            File.WriteAllText(path, jsonText);

            return true;
        }

        private static string Path(string placeholder, string filter)
        {
            
            SaveFileDialog sfd = new SaveFileDialog();
            string export = placeholder; 
            sfd.FileName = export;
            sfd.Filter = filter;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = sfd.InitialDirectory + sfd.FileName;
                return path;
            }
            else
            {
                MessageBox.Show("Please chose a valid path!");
                return null;
            }
        }
    }
}
    

