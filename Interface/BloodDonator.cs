using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
       //Classe responsavel por receber os dados provenientes do XML e devolver para a inicialização da lista. 
   public class BloodDonator
    {
        public int Number { get; private set; }
        public String Sexo { get; private set; }
        public String FirstName { get; private set; }
        public String LastName { get; private set; }
        public String StreetAddress { get; private set; }
        public String City { get; private set; }
        public String Statefull { get; private set; }
        public String ZipCode { get; private set; }
        public String Email { get; private set; }
        public String UserName{ get; private set; }
        public String Password { get; private set; }
        public long TelephoneNumber { get; private set; }
        public String MothersMaiden  { get; private set; }
        public DateTime BirthDay  { get; private set; }
        public int Age { get; private set; }
        public String Occupation { get; private set; }
        public String Company { get; private set; }
        public String Vehicle { get; private set; }
        public String BloodType{ get; private set; }
        public double Kilograms { get; private set; }
        public double Centimeters { get; private set; }
        public String Guid { get; private set; }
        public String Latitude { get; private set; }
        public String Longitude  { get; private set; }
        public double IMC { get; private set; }
        public object Convert { get; internal set; }

        public BloodDonator(int number, String sexo, String firstName, String lastName, String streetAddress,
                String city, String statefull, String zipCode, String eMail, String userName, String password,
                long telephoneNumber,
                String mothersMaiden, DateTime birthDay, int age, String occupation, String company, String vehicle,
                String bloodType,
                double kilograms, double centimeters, String guid, String latitude, String longitude, double imc)

        {

            Number = number;
            Sexo = sexo;
            FirstName = firstName;
            LastName = lastName;
            StreetAddress = streetAddress;
            City = city;
            Statefull = statefull;
            ZipCode = zipCode;
            Email = eMail;
            UserName = userName;
            Password = password;
            TelephoneNumber = telephoneNumber;
            MothersMaiden = mothersMaiden;
            BirthDay = birthDay;
            Age = age;
            Occupation = occupation;
            Company = company;
            Vehicle = vehicle;
            BloodType = bloodType;
            Kilograms = kilograms;
            Centimeters = centimeters;
            Guid = guid;
            Latitude = latitude;
            Longitude = longitude;
            IMC = imc; 

        }
    }
    
}



