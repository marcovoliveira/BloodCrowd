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
        //Método responsável por abrir ficheiro txt e inserir no ficheiro xml que será a base de dados
        [OperationContract]
        bool Devolver(String textotxt);

        //Método responsável por adicionar um novo dador
        [OperationContract]
        bool AddNewDonator(String sexo, String firstName, String lastName, String streetAddress,
                         String city, String statefull, String zipCode, String eMail, String userName, String password, String telephoneNumber,
                         String mothersMaiden, String birthDay, String age, String occupation, String company, String vehicle, String bloodType,
                         String kilograms, String centimeters, String guid, String latitude, String longitude);

        //Método responsável por garantir acesso à bd nas listagens
        [OperationContract]
        XmlElement DevolverXml();

        //Método responsável por remover dadores
        [OperationContract]
        bool RemoverDonator(int id);

        //Método responsável no auxílio da listagem correta do ficheiro xml(para a lista) e para adicionar novos dadores
        [OperationContract]
        XmlElement AddDonator(String number, String sexo, String firstName, String lastName, String streetAddress,
                         String city, String statefull, String zipCode, String eMail, String userName, String password, String telephoneNumber,
                         String mothersMaiden, String birthDay, String age, String occupation, String company, String vehicle, String bloodType,
                         String kilograms, String centimeters, String guid, String latitude, String longitude,XmlDocument doc);

    }
    }
