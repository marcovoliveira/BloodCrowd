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
            firstNameTextBox.Text = "Joao"; 
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
            XmlDeclaration decE= doc.CreateXmlDeclaration("1.0", null, null);
            doc.Load(@"BaseDados.xml");
            XmlNode root = doc.DocumentElement;

            XmlNode id = root.SelectSingleNode("Donator[last()]/@id");
            int a = Convert.ToInt32(id.InnerText);

             String number= Convert.ToString((a+1));
            
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
            String birthday = birthDaydateTimePicker.Text ;
            String occupation = occupationTextBox.Text;
            String company = companyTextBox.Text;
            String vehicle = vehicleTextBox.Text;
            String bloodType = bloodTypeComboBox.SelectedItem.ToString();
            String kilograms = kilogramsTextBox.Text;
            String centimeters = centimetersTextBox.Text;
            String password = "********";
            String guid = "*******";
            String latitude = "";
            String longitude = "";
            String vazio = "";
            //calcular idade
            var hoje = DateTime.Today;
            
            String[] bday = birthday.Split(' ');
            int bd = Convert.ToInt32(bday[4]);

            int idade = hoje.Year - bd;
            String age = Convert.ToString(idade);

            //colocar bem a data
            //  1 / 10 / 1953
            int b;
            String dn="";
            String[] meses = { "janeiro", "fevereiro", "março", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro" };
            for (int k = 0; k < meses.Count(); k++)
            {
                if (bday[2].Equals(meses[k]))
                {
                    b = k + 1;
                    dn = bday[0] + "/" + b + "/" + bday[4];
                }

               
            }
            //validar campos preenchidos

            if (genero == vazio || firstName == vazio || lastName == vazio || streetAddress == vazio || city == vazio ||
                statefull == vazio || zipCode == vazio || email == vazio || username == vazio || telephone == vazio ||
                mothersMaiden == vazio || occupation == vazio || company == vazio || kilograms == vazio || centimeters == vazio)
            {
                MessageBox.Show("Fill all the boxes!");
            }
            else
            {

               root.AppendChild(AddNewDonator.AddDonator(number, genero, firstName, lastName, streetAddress, city, statefull, zipCode, email, username, password, telephone,
                  mothersMaiden, dn, age, occupation, company, vehicle, bloodType, kilograms, centimeters, guid, latitude, longitude, doc));
                MessageBox.Show("Donator added with success!");
                
                doc.Save(@"BaseDados.xml");
                                


            }
        }
    }
}
    