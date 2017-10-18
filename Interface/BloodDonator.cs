using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class BloodDonator
    {
        public int Number { get; private set; }
        public char Sexo { get; private set; }
        public String FirstName { get; private set; }
        public String LastName { get; private set; }
        public String StreetAddress { get; private set; }
        public String  City { get; private set; }
        public String Statefull { get; private set; }
        public String ZipCode { get; private set; }
        public String  Email { get; private set; }
        public String   UserName{ get; private set; }
        public String Password { get; private set; }
        public long TelephoneNumber { get; private set; }
        public String MothersMaiden  { get; private set; }
        public DateTime BirthDay  { get; private set; }
        public int Age { get; private set; }
        public String Occupation { get; private set; }
        public String  Company { get; private set; }
        public String Vehicle { get; private set; }
        public String  BloodType{ get; private set; }
        public float Kilograms { get; private set; }
        public float Centimeters;
        public String Guid { get; private set; }
        public double Latitude { get; private set; }
        public Double Longitude  { get; private set; }

        public BloodDonator(int number, char sexo, String firstName, String lastName, String streetAddress,
                String city, String statefull, String zipCode, String eMail, String userName, String password,
                long telephoneNumber,
                String mothersMaiden, DateTime birthDay, int age, String occupation, String company, String vehicle,
                String bloodType,
                float kilograms, float centimeters, String guid, double latitude, double longitude)

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

        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
    
}



