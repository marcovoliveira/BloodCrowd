using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class ViewDonatorForm : Form
    {
        public int number;
        private Font printFont;
        private StreamReader streamToPrint;

        public ViewDonatorForm(string id)
        {   
            
            InitializeComponent();
            number = Convert.ToInt32(id); 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var donators = CreateListDonators.ListDonators();
            string[] a;
            string []b;
            foreach (var item in donators.Where(item => item.Number == number))
            {
                a = Regex.Split(item.StreetAddress, @"(?<!^)(?=[A-Z])");

                b = Regex.Split(item.Vehicle, @"(?<!^)(?=[A-Z])");

                
                firstNameLabel.Text = item.FirstName;
                lastNameLabel.Text = item.LastName;
                //colocar bem a morada
                streetAdressLabel.ResetText();
                for (int i = 0; i < a.Count(); i++)
                {
                    streetAdressLabel.Text = streetAdressLabel.Text + " " + a[i];

                }
                //colocar bem o veiculo
                veichleLabel.ResetText();
                for(int k=0;k<b.Count();k++)
                {
                    veichleLabel.Text = veichleLabel.Text + " " + b[k];
                }
               
                cityLabel.Text = item.City;
                stateFullLabel.Text = item.Statefull;
                zipcodeLabel.Text = item.ZipCode;
                emailLabel.Text = item.Email;
                usernameLabel.Text = item.UserName;
                telephoneLabel.Text = Convert.ToString(item.TelephoneNumber);
                motherMaidenLabel.Text = item.MothersMaiden;
                //colocar data bem
                birthdayLabel.Text = item.BirthDay.Day +"/" + item.BirthDay.Month + "/" + item.BirthDay.Year;
                ageLabel.Text = Convert.ToString(item.Age);
                ocupationLabel.Text = item.Occupation;
                companyLabel.Text = item.Company;
              
                bloodTypeLabel.Text = item.BloodType;
                kilogramsLabel.Text = Convert.ToString(item.Kilograms);
                centimetersLabel.Text = Convert.ToString(item.Centimeters);
                latitudeLabel.Text = item.Latitude;
                longitudeLabel.Text = item.Longitude;



            }
        }

        private void lastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void cityLabel_Click(object sender, EventArgs e)
        {

        }

        private void stateFullLabel_Click(object sender, EventArgs e)
        {

        }

        private void telephoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void ocupationLabel_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void streetAdressLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
