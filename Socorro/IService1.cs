using System;
using System.Collections.Generic;
using System.Linq;
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

        [OperationContract]
        List<BloodDonator> ListDonators();

        [OperationContract]
        List<BloodDonator> ListaDonators();

        [OperationContract]
        bool Devolver(String textotxt);

        [OperationContract]
        XmlElement AddDonator(String number, String sexo, String firstName, String lastName, String streetAddress,
                         String city, String statefull, String zipCode, String eMail, String userName, String password, String telephoneNumber,
                         String mothersMaiden, String birthDay, String age, String occupation, String company, String vehicle, String bloodType,
                         String kilograms, String centimeters, String guid, String latitude, String longitude, XmlDocument doc);
    }
    [DataContract]
    public class BloodDonator
    {
        private int id;
        private string primeiro_nome;
        private string ultimo_nome;
        private string rua;
        private string cidade;
        private string distrito;
        private string codigo_postal;
        private long telefone;
        private string nome_mae;
        private DateTime data_nascimento;
        private int idade;
        private string ocupacao;
        private string empresa;
        private string veiculo;
        private string tipo_sangue;
        private double peso;
        private double altura;

        public BloodDonator(int id, string sexo, string primeiro_nome, string ultimo_nome, string rua, string cidade, string distrito, string codigo_postal, string email, string username, string password, long telefone, string nome_mae, DateTime data_nascimento, int idade, string ocupacao, string empresa, string veiculo, string tipo_sangue, double peso, double altura, string guid, string latitude, string longitude, double iMC)
        {
            this.id = id;
            Sexo = sexo;
            this.primeiro_nome = primeiro_nome;
            this.ultimo_nome = ultimo_nome;
            this.rua = rua;
            this.cidade = cidade;
            this.distrito = distrito;
            this.codigo_postal = codigo_postal;
            Email = email;
            UserName = username;
            Password = password;
            this.telefone = telefone;
            this.nome_mae = nome_mae;
            this.data_nascimento = data_nascimento;
            this.idade = idade;
            this.ocupacao = ocupacao;
            this.empresa = empresa;
            this.veiculo = veiculo;
            this.tipo_sangue = tipo_sangue;
            this.peso = peso;
            this.altura = altura;
            Guid = guid;
            Latitude = latitude;
            Longitude = longitude;
            IMC = iMC;
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
        public String Email { get; private set; }

        [DataMember]
        public String UserName { get; private set; }

        [DataMember]
        public String Password { get; private set; }

        [DataMember]
        public long TelephoneNumber { get; private set; }

        [DataMember]
        public String MothersMaiden { get; private set; }

        [DataMember]
        public DateTime BirthDay { get; private set; }

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
        public double IMC { get; private set; }
        


    }
    }
