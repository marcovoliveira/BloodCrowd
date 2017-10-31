using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Interface
{
    public partial class AddDonatorForm : Form
    {
        public AddDonatorForm()
        {
            InitializeComponent();

            //Conteudo da comboBox do sexo
            genreComboBox.Items.Add("male");
            genreComboBox.Items.Add("female");
            genreComboBox.SelectedIndex = 1;

            //Conteudo da comboBox do grupo sanguíneo
            bloodTypeComboBox.Items.Add("A+");
            bloodTypeComboBox.Items.Add("A-");
            bloodTypeComboBox.Items.Add("B+");
            bloodTypeComboBox.Items.Add("B-");
            bloodTypeComboBox.Items.Add("AB+");
            bloodTypeComboBox.Items.Add("AB-");
            bloodTypeComboBox.Items.Add("O+");
            bloodTypeComboBox.Items.Add("O-");
            bloodTypeComboBox.SelectedIndex = 0;




        }

        private void AddDonatorForm_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void birthdayDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void telephoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void genreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void AddDonatorButton_Click(object sender, EventArgs e)
        {
            
            XmlDocument doc = new XmlDocument();
            doc.Load(@"BaseDados.xml");




            XmlNode person = doc.SelectSingleNode("//Donators[last()]/@id");

            String genero = genreComboBox.SelectedItem.ToString();
            String firstName = firstNameTextBox.Text;
            String lastName = lastNameTextBox.Text;
            String streetAddress = streetAddressTextBox.Text;
            String city = cityTextBox.Text;
            String statefull = stateFullTextBox.Text;
            String zipCode = zipCodeTextBox.Text;
            String email = emailTextBox.Text;
            String username = userNameTextBox.Text;
            String telephone = telephoneTextBox.Text;
            String mothersMaiden = mothersMaidenTextBox.Text;
            String birthday = birthDaydateTimePicker.Text;
            String occupation = occupationTextBox.Text;
            String company = companyTextBox.Text;
            String vehicle = vehicleTextBox.Text;
            String bloodType = bloodTypeComboBox.SelectedItem.ToString();
            String kilograms = kilogramsTextBox.Text;
            String centimeters = centimetersTextBox.Text;
            MessageBox.Show(Convert.ToString(person.InnerText));
            // AddNewDonator.AddDonator();

            //doc.Save(@"BaseDados.xml");
        }
    }
}
    