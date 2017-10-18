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
        // Metodo que recebe os dados do donator e cria um nood do dador com os dados. 
        public static XmlElement AddDonator(String number, String sexo, String firstName, String lastName, String streetAddress,
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

    }
}
