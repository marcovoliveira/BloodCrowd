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
            XmlElement donator = doc.CreateElement("Donator");
            donator.SetAttribute("id", number);
            //doc.AppendChild(donator);

            XmlElement genero = doc.CreateElement("Sexo");
            genero.InnerText = sexo;

            XmlElement primeiroNome = doc.CreateElement("Primeiro_Nome");
            primeiroNome.InnerText = firstName;

            XmlElement ultimoNome = doc.CreateElement("Ultimo_Nome");
            ultimoNome.InnerText = lastName;

            XmlElement rua = doc.CreateElement("Rua");
            rua.InnerText = streetAddress;

            XmlElement cidade = doc.CreateElement("Cidade");
            cidade.InnerText = city;

            XmlElement destrito = doc.CreateElement("Destrito");
            destrito.InnerText = statefull;

            XmlElement codigoPostal = doc.CreateElement("Codigo_Postal");
            codigoPostal.InnerText = zipCode;

            XmlElement mail = doc.CreateElement("Email");
            mail.InnerText = eMail;

            XmlElement userN = doc.CreateElement("Username");
            userN.InnerText = userName;

            XmlElement pwd = doc.CreateElement("Password");
            pwd.InnerText = password;

            XmlElement telefone = doc.CreateElement("Telefone");
            telefone.InnerText = telephoneNumber;

            XmlElement nomeDaMae = doc.CreateElement("Nome_da_mae");
            nomeDaMae.InnerText = mothersMaiden;

            XmlElement dataNasc = doc.CreateElement("Data_Nascimento");
            dataNasc.InnerText = birthDay;

            XmlElement idade = doc.CreateElement("Idade");
            idade.InnerText = age;

            XmlElement ocupacao = doc.CreateElement("Ocupaçao");
            ocupacao.InnerText = occupation;

            XmlElement empresa = doc.CreateElement("Empresa");
            empresa.InnerText = company;

            XmlElement veiculo = doc.CreateElement("Veiculo");
            veiculo.InnerText = vehicle;

            XmlElement tipoSanguineo = doc.CreateElement("Tipo_Sanguineo");
            tipoSanguineo.InnerText = bloodType;

            XmlElement peso = doc.CreateElement("Peso");

            peso.InnerText = kilograms;

            XmlElement altura = doc.CreateElement("Altura");
            altura.InnerText = centimeters;

            XmlElement guId = doc.CreateElement("GUID");
            guId.InnerText = guid;

            XmlElement lat = doc.CreateElement("Latitude");
            lat.InnerText = latitude;

            XmlElement lon = doc.CreateElement("Longitude");
            lon.InnerText = longitude;


            

            //guid latitute longitude



            
            donator.AppendChild(genero);
            donator.AppendChild(primeiroNome);
            donator.AppendChild(ultimoNome);
            donator.AppendChild(rua);
            donator.AppendChild(cidade);
            donator.AppendChild(destrito);
            donator.AppendChild(codigoPostal);
            donator.AppendChild(mail);
            donator.AppendChild(userN);
            donator.AppendChild(pwd);
            donator.AppendChild(telefone);
            donator.AppendChild(nomeDaMae);
            donator.AppendChild(dataNasc);
            donator.AppendChild(idade);
            donator.AppendChild(ocupacao);
            donator.AppendChild(empresa);
            donator.AppendChild(veiculo);
            donator.AppendChild(tipoSanguineo);
            donator.AppendChild(peso);
            donator.AppendChild(altura);
            donator.AppendChild(guId);
            donator.AppendChild(lat);
            donator.AppendChild(lon);
            MessageBox.Show(donator.InnerXml);


            return donator;
        }

    }
}
