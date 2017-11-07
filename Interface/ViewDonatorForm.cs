using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class ViewDonatorForm : Form
    {
        public int number; 

        public ViewDonatorForm(string id)
        {   
            
            InitializeComponent();
            number = Convert.ToInt32(id); 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var donators = CreateListDonators.ListDonators();
            foreach (var item in donators.Where(item => item.Number == number))
            {
                firstNameLabel.Text = item.FirstName;
                lastNameLabel.Text = item.LastName;
                streetAdressLabel.Text = item.StreetAddress;
                cityLabel.Text = item.City;
                stateFullLabel.Text = item.Statefull;
                zipcodeLabel.Text = item.ZipCode;
                emailLabel.Text = item.Email;
                usernameLabel.Text = item.UserName;
                telephoneLabel.Text = Convert.ToString(item.TelephoneNumber);
                motherMaidenLabel.Text = item.MothersMaiden;
                birthdayLabel.Text = Convert.ToString(item.BirthDay);
                ageLabel.Text = Convert.ToString(item.Age);
                ocupationLabel.Text = item.Occupation;
                companyLabel.Text = item.Company;
                veichleLabel.Text = item.Vehicle;
                bloodTypeLabel.Text = item.BloodType;
                kilogramsLabel.Text = Convert.ToString(item.Kilograms);
                centimetersLabel.Text = Convert.ToString(item.Centimeters);
                latitudeLabel.Text = item.Latitude;
                longitudeLabel.Text = item.Longitude;



            }
        }

        private void birthdayLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
