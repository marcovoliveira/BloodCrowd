using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Hosting;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Socorro
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Service1.svc ou Service1.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class Service1 : IService1
    {

        private static string FILEPATH;
        public Service1()
        {
            FILEPATH = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, "App_Data", "BaseDados.xml");
        }

        public bool RemoverDonator(int id)
        {
            bool sucesso = true;
            try
            {
               
                XmlDocument doc = new XmlDocument();
                doc.Load(FILEPATH);
                XmlNode node = doc.SelectSingleNode("//Donator[@id=" + id + "]");
                XmlNode root = doc.DocumentElement;
                root.RemoveChild(node);
                doc.Save(FILEPATH);
            }
            catch (Exception e)
            {
                sucesso = false;
            }
           return sucesso;
        }

        public bool AddNewDonator(String sexo, String firstName, String lastName, String streetAddress,
                         String city, String statefull, String zipCode, String eMail, String userName, String password, String telephoneNumber,
                         String mothersMaiden, String birthDay, String age, String occupation, String company, String vehicle, String bloodType,
                         String kilograms, String centimeters, String guid, String latitude, String longitude)
        {
            XmlDocument doc = new XmlDocument();
           
            doc.Load(FILEPATH);
            XmlNode root = doc.DocumentElement;
            XmlNode id = root.SelectSingleNode("Donator[last()]/@id");
            int idU = Convert.ToInt32(id.InnerText);
            String idUltimo = Convert.ToString(idU + 1);

            root.AppendChild(AddDonator(idUltimo, sexo, firstName, lastName, streetAddress, city, statefull, zipCode, eMail, userName, password, telephoneNumber, mothersMaiden
                , birthDay, age, occupation, company, vehicle, bloodType, kilograms, centimeters, guid, latitude, longitude, doc));
            doc.Save(FILEPATH);


            return true;
        }
        public XmlElement DevolverXml()
        {
            

            XmlDocument doc = new XmlDocument();
            doc.Load(FILEPATH);
            // MessageBox.Show(doc.InnerXml);
            XmlElement xmle = doc.DocumentElement;
         
            return xmle;

        }
        
        public bool Devolver(String textotxt)
        {

            bool sucesso = false;
            String receber = File.ReadAllText(textotxt);

            char d = '\n';
            char f = '|';



            String[] dadosPorEnter = receber.Split(d);
            int dadosPorEnterSize = dadosPorEnter.Length;

            String[] dado;



            List<String> dados = new List<String>();
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", null, null);
            doc.AppendChild(dec);
            XmlElement
                root = doc.CreateElement(
                    "DonatorsList"); // Criar um root onde os Elementos Donators irão ser introduzidos
            doc.AppendChild(root);

            for (int i = 1; i < dadosPorEnterSize; i++)
            {
                dados.Add(dadosPorEnter[i]); //adicionar pessoa          
            }


            for (int j = 0;
                j < dados.Count - 1;
                j++) //dados -1 para não contar o ultimo elemento da lista dados que esta em branco 
            {

                dado = dados[j].Split(f); //dividir pessoa por pipe

                for (int k = 0; k < dado.Length; k++) //remove os espaços e o caracter especial no 1
                {

                    //dado[k] = Regex.Replace(dado[k], @"\s+", " "); //remove espaços

                    dado[k] = dado[k].Trim();
                    dado[0] = Regex.Replace(dado[0], @"§", ""); //remove caracter especial que apenas aparece no primeiro elemento
                    dado[19] = dado[19].Replace('.', ',');
                }


                //chamada do Metodo AddDonator a cada iteração que ira introduzir um Elemento Donator na DonatorsList
                root.AppendChild(AddDonator(dado[0], dado[1], dado[2], dado[3],
                    dado[4], dado[5], dado[6], dado[7], dado[8],
                    dado[9], dado[10], dado[11], dado[12], dado[13],
                    dado[14], dado[15], dado[16], dado[17], dado[18],
                    dado[19], dado[20], dado[21], dado[22],
                    dado[23], doc));

                FILEPATH = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, "App_Data", "BaseDados.xml");
                doc.Save(FILEPATH);


                sucesso = true;
            }
            return sucesso;
        }
        public XmlElement AddDonator(String number, String sexo, String firstName, String lastName, String streetAddress,
                         String city, String statefull, String zipCode, String eMail, String userName, String password, String telephoneNumber,
                         String mothersMaiden, String birthDay, String age, String occupation, String company, String vehicle, String bloodType,
                         String kilograms, String centimeters, String guid, String latitude, String longitude, XmlDocument doc)
        {
            XmlElement donator = doc.CreateElement("Donator");
            donator.SetAttribute("id", number);
            //doc.AppendChild(donator);



            XmlElement genero = doc.CreateElement("Sexo");
            donator.AppendChild(genero);
            genero.InnerText = sexo;

            XmlElement primeiroNome = doc.CreateElement("Primeiro_Nome");
            donator.AppendChild(primeiroNome);
            primeiroNome.InnerText = firstName;

            XmlElement ultimoNome = doc.CreateElement("Ultimo_Nome");
            donator.AppendChild(ultimoNome);
            ultimoNome.InnerText = lastName;

            XmlElement rua = doc.CreateElement("Rua");
            donator.AppendChild(rua);
            rua.InnerText = streetAddress;

            XmlElement cidade = doc.CreateElement("Cidade");
            donator.AppendChild(cidade);
            cidade.InnerText = city;

            XmlElement distrito = doc.CreateElement("Distrito");
            donator.AppendChild(distrito);
            distrito.InnerText = statefull;

            XmlElement codigoPostal = doc.CreateElement("Codigo_Postal");
            donator.AppendChild(codigoPostal);
            codigoPostal.InnerText = zipCode;

            XmlElement mail = doc.CreateElement("Email");
            donator.AppendChild(mail);
            mail.InnerText = eMail;

            XmlElement userN = doc.CreateElement("Username");
            donator.AppendChild(userN);
            userN.InnerText = userName;

            XmlElement pwd = doc.CreateElement("Password");
            donator.AppendChild(pwd);
            pwd.InnerText = password;

            XmlElement telefone = doc.CreateElement("Telefone");
            donator.AppendChild(telefone);
            telefone.InnerText = telephoneNumber;

            XmlElement nomeDaMae = doc.CreateElement("Nome_da_mae");
            donator.AppendChild(nomeDaMae);
            nomeDaMae.InnerText = mothersMaiden;

            XmlElement dataNasc = doc.CreateElement("Data_Nascimento");
            donator.AppendChild(dataNasc);
            dataNasc.InnerText = birthDay;

            XmlElement idade = doc.CreateElement("Idade");
            donator.AppendChild(idade);
            idade.InnerText = age;

            XmlElement ocupacao = doc.CreateElement("Ocupaçao");
            donator.AppendChild(ocupacao);
            ocupacao.InnerText = occupation;

            XmlElement empresa = doc.CreateElement("Empresa");
            donator.AppendChild(empresa);
            empresa.InnerText = company;

            XmlElement veiculo = doc.CreateElement("Veiculo");
            donator.AppendChild(veiculo);
            veiculo.InnerText = vehicle;

            XmlElement tipoSanguineo = doc.CreateElement("Tipo_Sanguineo");
            donator.AppendChild(tipoSanguineo);
            tipoSanguineo.InnerText = bloodType;

            XmlElement peso = doc.CreateElement("Peso");
            donator.AppendChild(peso);
            peso.InnerText = kilograms;

            XmlElement altura = doc.CreateElement("Altura");
            donator.AppendChild(altura);
            altura.InnerText = centimeters;

            XmlElement guId = doc.CreateElement("GUID");
            donator.AppendChild(guId);
            guId.InnerText = guid;

            XmlElement lat = doc.CreateElement("Latitude");
            donator.AppendChild(lat);
            lat.InnerText = latitude;

            XmlElement lon = doc.CreateElement("Longitude");
            donator.AppendChild(lon);
            lon.InnerText = longitude;

            return donator;
        }

        public List<BloodDonator> ListDonators()
        {
            List<BloodDonator> ListDonators = new List<BloodDonator>();

            IFormatProvider culture = new System.Globalization.CultureInfo("en-US", true);

            try
            {
                XDocument xdoc = XDocument.Load(FILEPATH);

                foreach (var dm in xdoc.Descendants("Donator"))
                {
                    int id = Convert.ToInt32(dm.Attribute("id").Value);
                    String sexo = dm.Element("Sexo").Value;
                    String primeiro_nome = dm.Element("Primeiro_Nome").Value;
                    String ultimo_nome = dm.Element("Ultimo_Nome").Value;
                    String rua = dm.Element("Rua").Value;
                    String cidade = dm.Element("Cidade").Value;
                    String distrito = dm.Element("Distrito").Value;
                    String codigo_postal = dm.Element("Codigo_Postal").Value;
                    String email = dm.Element("Email").Value;
                    String username = dm.Element("Username").Value;
                    String password = dm.Element("Password").Value;
                    long telefone = Convert.ToInt64(dm.Element("Telefone").Value);
                    String nome_mae = dm.Element("Nome_da_mae").Value;
                    DateTime data_nascimento = DateTime.Parse(dm.Element("Data_Nascimento").Value, culture, DateTimeStyles.AssumeLocal);
                    int idade = Convert.ToInt32(dm.Element("Idade").Value);
                    String ocupacao = dm.Element("Ocupaçao").Value;
                    String empresa = dm.Element("Empresa").Value;
                    String veiculo = dm.Element("Veiculo").Value;
                    String tipo_sangue = dm.Element("Tipo_Sanguineo").Value;
                    double peso = Convert.ToDouble(dm.Element("Peso").Value);
                    double altura = Convert.ToDouble(dm.Element("Altura").Value);
                    String guid = dm.Element("GUID").Value;
                    String latitude = dm.Element("Latitude").Value;
                    String longitude = dm.Element("Longitude").Value;
                    double IMC = CalcularIMC(peso, altura);

                    ListDonators.Add(new BloodDonator(id, sexo, primeiro_nome, ultimo_nome, rua, cidade, distrito, codigo_postal, email, username,
                        password, telefone, nome_mae, data_nascimento, idade, ocupacao, empresa, veiculo, tipo_sangue, peso, altura,
                        guid, latitude, longitude, IMC));

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());

            }

            return ListDonators;
        }
        public List<BloodDonator> ListaDonators()
        {
            List<BloodDonator> donators = new List<BloodDonator>();
            donators = ListDonators();
            return donators;
        }

        public double CalcularIMC(double peso, double altura)
        {
            double imc;
            imc = peso / ((altura * altura) / 10000);
            return imc;
        }
        public bool ExportJSON(List<int> posicao, string path)
        {
            List<BloodDonator> donators = new List<BloodDonator>();
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





            for (int i = 0; i < posicao.Count(); i++)
            {

                // Defesa do projeto! 
                //  foreach (BloodDonator b in donators.Where(n => n.Number == id[i]).Where(a => a.BloodType.Equals("A+")))
                foreach (BloodDonator b in donators.Where(n => n.Number == posicao[i]))
                {

                    number = Convert.ToString(b.Number);
                    sexo = b.Sexo;
                    firstName = b.FirstName;
                    lastName = b.LastName;
                    streetAddress = b.StreetAddress;
                    city = b.City;
                    statefull = b.Statefull;
                    zipCode = b.ZipCode;
                    eMail = b.EMail;
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

                    rootExportar.AppendChild(AddDonator(number, sexo, firstName, lastName, streetAddress, city, statefull, zipCode, eMail, userName, password,
                         telephoneNumber, mothersMaiden, birthDay, age, occupation, company, vehicle, bloodType, kilograms, centimeters,
                         guid, latitude, longitude, docExportar));
                }

            }
            String jsonText = "";
            jsonText += JsonConvert.SerializeObject(rootExportar);
            File.WriteAllText(path, jsonText);

            return true;
        }

        public bool ExportarXML(List<int> posicao, string caminhoGuardar)
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
                foreach (BloodDonator b in ListaDonators().Where(n => n.Number == posicao[i]))
                {
                    number = Convert.ToString(b.Number);
                    sexo = b.Sexo;
                    firstName = b.FirstName;
                    lastName = b.LastName;
                    streetAddress = b.StreetAddress;
                    city = b.City;
                    statefull = b.Statefull;
                    zipCode = b.ZipCode;
                    eMail = b.EMail;
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

                    rootExportar.AppendChild(AddDonator(number, sexo, firstName, lastName, streetAddress, city, statefull, zipCode, eMail, userName, password,
                        telephoneNumber, mothersMaiden, birthDay, age, occupation, company, vehicle, bloodType, kilograms, centimeters,
                        guid, latitude, longitude, docExportar));
                    docExportar.Save(caminhoGuardar);
                }
            }
            return true;
        }



    }
    }

