using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

namespace Socorro
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService1" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IService1
    {
        //Método responsável por abrir ficheiro txt e inserir no ficheiro xml que será a base de dados
        [OperationContract]
        bool Devolver(String textotxt);

        //Método responsável por adicionar um novo dador
        [OperationContract]
        //deve devolver true
        [WebInvoke(Method ="POST", UriTemplate = "/donator/AddDonator/{bd}")]
        [Description("Posts a donator at xml file")]
        bool AddNewDonator(BloodDonator bd);

        //Método responsável por garantir acesso à bd nas listagens
        [OperationContract]
        XmlElement DevolverXml();

        //Método responsável por remover dadores
        [OperationContract]
        //deve vevolver true se eliminar
        [WebInvoke(Method = "DELETE", UriTemplate = "/donator/RemoveDonator/{id}")]
        [Description("Removes a donator/list of donators at xml file")]
        bool RemoverDonator(int id);

        [OperationContract]
        List<BloodDonator> ListDonators();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/donator/CalcularImc")]
        [Description("Calculates IMC.")]
        double CalcularIMC(double peso, double altura);

        [OperationContract]
        List<BloodDonator> ListaDonators();

        //Método responsável no auxílio da listagem correta do ficheiro xml(para a lista) e para adicionar novos dadores
        [OperationContract]
        //diz que nao funciona pq é do tipo Xml
        [WebInvoke(Method = "POST", UriTemplate = "/donator/Add")]
        [Description("Add a donator to list")]
        XmlElement AddDonator(String number, String sexo, String firstName, String lastName, String streetAddress,
                         String city, String statefull, String zipCode, String eMail, String userName, String password, String telephoneNumber,
                         String mothersMaiden, String birthDay, String age, String occupation, String company, String vehicle, String bloodType,
                         String kilograms, String centimeters, String guid, String latitude, String longitude,XmlDocument doc);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/donator/ExportXml")]
        [Description("Gets a list of donators in xml file")]
        bool ExportarXML(List<int> posicao, string caminhoGuardar);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/donator/ExportJson")]
        [Description("Gets a list of donators in json file")]
        bool ExportJSON(List<int> posicao, string path);

        [OperationContract]
        void SendEmails(string email, string bloodtype);

        [OperationContract]
        NetworkCredential Credentials();




    }
    //Criação da classe BloodDonator
    [DataContract]
    public class BloodDonator
    {
        public BloodDonator(int number, String sexo, String firstName, String lastName, String streetAddress,
                String city, String statefull, String zipCode, String eMail, String userName, String password,
                long telephoneNumber,
                String mothersMaiden, String birthDay, int age, String occupation, String company, String vehicle,
                String bloodType,
                double kilograms, double centimeters, String guid, String latitude, String longitude, double imc)
        {
            this.Number = number;
            this.Sexo = sexo;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.StreetAddress = streetAddress;
            this.City = city;
            this.Statefull = statefull;
            this.ZipCode = zipCode;
            this.EMail = eMail;
            this.UserName = userName;
            this.Password = password;
            this.TelephoneNumber = telephoneNumber;
            this.MothersMaiden = mothersMaiden;
            this.BirthDay = birthDay;
            this.Age = age;
            this.Occupation = occupation;
            this.Company = company;
            this.Vehicle = vehicle;
            this.BloodType = bloodType;
            this.Kilograms = kilograms;
            this.Centimeters = centimeters;
            this.Guid = guid;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Imc = imc;
            
        }
        [DataMember]
        public int Number { get; private set; }

        [DataMember]
        public String Sexo { get; private set; }

        [DataMember]
        public String FirstName { get; private set; }

        [DataMember]
        public String LastName { get; private set; }

        [DataMember]
        public String StreetAddress { get; private set; }

        [DataMember]
        public String City { get; private set; }

        [DataMember]
        public String Statefull { get; private set; }

        [DataMember]
        public String ZipCode { get; private set; }

        [DataMember]
        public String EMail { get; private set; }

        [DataMember]
        public String UserName { get; private set; }

        [DataMember]
        public String Password { get; private set; }

        [DataMember]
        public long TelephoneNumber { get; private set; }

        [DataMember]
        public String MothersMaiden { get; private set; }

        [DataMember]
        public String BirthDay { get; private set; }

        [DataMember]
        public int Age { get; private set; }

        [DataMember]
        public String Occupation { get; private set; }

        [DataMember]
        public String Company { get; private set; }

        [DataMember]
        public String Vehicle { get; private set; }

        [DataMember]
        public String BloodType { get; private set; }

        [DataMember]
        public double Kilograms { get; private set; }

        [DataMember]
        public double Centimeters { get; private set; }

        [DataMember]
        public String Guid { get; private set; }

        [DataMember]
        public String Latitude { get; private set; }

        [DataMember]
        public String Longitude { get; private set; }

        [DataMember]
        public double Imc { get; private set; }

        public override string ToString()
        {
            string bd = string.Empty;
            bd += "Number: " + Number + Environment.NewLine;
            bd +=  "Sex: " + Sexo + Environment.NewLine;
            bd += "First Name: " + FirstName + Environment.NewLine;
            bd += "Last Name: " +LastName + Environment.NewLine;
            bd += "Street Address: " + StreetAddress +Environment.NewLine;
            bd += "City: " + City + Environment.NewLine;
            bd += "Statefull: " + Statefull + Environment.NewLine;
            bd += "ZipCode: " + ZipCode + Environment.NewLine;
            bd += "EMail: " + EMail + Environment.NewLine;
            bd += "UserName: " + UserName + Environment.NewLine;
            bd += "Password: " + Password + Environment.NewLine;
            bd += "TelephoneNumber: " + TelephoneNumber + Environment.NewLine;
            bd += "MothersMaiden: " + MothersMaiden + Environment.NewLine;
            bd += "BirthDay: " + BirthDay + Environment.NewLine;
            bd += "Age: " + Age + Environment.NewLine;
            bd += "Occupation: " + Occupation + Environment.NewLine;
            bd += "Company: " + Company + Environment.NewLine;
            bd += "Vehicle: " + Vehicle + Environment.NewLine;
            bd += "BloodType: " + BloodType + Environment.NewLine;
            bd += "Kilograms: " + Kilograms + Environment.NewLine;
            bd += "Centimeters: " + Centimeters + Environment.NewLine;
            bd += "Guid: " + Guid + Environment.NewLine;
            bd += "Latitude: " + Latitude + Environment.NewLine;
            bd += "Longitude: " + Longitude + Environment.NewLine;
            bd += "Imc: " + Imc + Environment.NewLine;
           
            return bd;
        }

    }
}
