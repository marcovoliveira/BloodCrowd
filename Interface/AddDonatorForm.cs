using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            firstNameTextBox.Text = "João";
            lastNameTextBox.Text = "Ferreira";
            genreComboBox.SelectedIndex = 1;
            streetAddressTextBox.Text = "Rua Principal 39";
            cityTextBox.Text = "Alcobaça";
            stateFullTextBox.Text = "Leiria";
            zipCodeTextBox.Text = "2460-611";
            emailTextBox.Text = "jfa@gmail.com";
            userNameTextBox.Text = "Jferr";
            telephoneTextBox.Text = "927068903";
            mothersMaidenTextBox.Text = "Santos";
            occupationTextBox.Text = "Operador fabril";
            companyTextBox.Text = "Frubaça";
            vehicleTextBox.Text = "BMW 320d";
            kilogramsTextBox.Text = "92,5";
            centimetersTextBox.Text = "170,5";

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
            
            bool resultadoint = int.TryParse(telephoneTextBox.Text, out var n);
            bool resultadodouble = double.TryParse(kilogramsTextBox.Text, out var p);
            bool resultaddouble2 = double.TryParse(centimetersTextBox.Text, out var l);



            string especiais = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
            //validar campos preenchidos

            if (genreComboBox.Text == String.Empty || firstNameTextBox.Text == String.Empty || lastNameTextBox.Text == String.Empty ||
                streetAddressTextBox.Text == String.Empty || cityTextBox.Text == String.Empty || stateFullTextBox.Text == String.Empty ||
                zipCodeTextBox.Text == String.Empty || emailTextBox.Text == String.Empty || userNameTextBox.Text == String.Empty ||
                telephoneTextBox.Text == String.Empty || mothersMaidenTextBox.Text == String.Empty || occupationTextBox.Text == String.Empty ||
                companyTextBox.Text == String.Empty || vehicleTextBox.Text == String.Empty || kilogramsTextBox.Text == String.Empty ||
                 centimetersTextBox.Text == String.Empty || resultadoint == false || resultaddouble2 == false || resultadodouble == false||
                !Regex.IsMatch(firstNameTextBox.Text, @"^[\sa-zA-Z" + especiais+"]*$" ) || !Regex.IsMatch(lastNameTextBox.Text, @"^[\sa-zA-Z" + especiais + "]*$") || 
               !Regex.IsMatch(cityTextBox.Text, @"^[\sa-zA-Z" + especiais + "]*$") || !Regex.IsMatch(stateFullLabel.Text, @"^[\sa-zA-Z" + especiais + "]*$") || !Regex.IsMatch(mothersMaidenTextBox.Text, @"^[\sa-zA-Z" + especiais + "]*$")  ||
               !Regex.IsMatch(occupationTextBox.Text, @"^[\sa-zA-Z" + especiais + "]*$") || !Regex.IsMatch(companyTextBox.Text, @"^[\sa-zA-Z" + especiais + "]*$")||
               !Regex.IsMatch(streetAddressTextBox.Text, @"^[\sa-zA-Z" + especiais + "0-9]*$"))
            {
                MessageBox.Show("Fill all the fields correctly!");
            }
            else
            {
                


                XmlDocument doc = new XmlDocument();
                
                doc.Load(@"BaseDados.xml");
                XmlNode root = doc.DocumentElement;

                XmlNode id = root.SelectSingleNode("Donator[last()]/@id");
                int a = Convert.ToInt32(id.InnerText);

                String number = Convert.ToString((a + 1));

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
                String password ="";
                String guid = "";
                String latitude = "";
                String longitude = "";
                
                //calcular idade
                var hoje = DateTime.Today;

                String[] bday = birthday.Split(' ');
                int bd = Convert.ToInt32(bday[4]);

                int idade = hoje.Year - bd;
                String age = Convert.ToString(idade);

                //colocar bem a data
                //  1 / 10 / 1953
                int b;
                String dn = "";
                String[] meses = { "janeiro", "fevereiro", "março", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro" };
                for (int k = 0; k < meses.Count(); k++)
                {
                    if (bday[2].Equals(meses[k]))
                    {
                        b = k + 1;
                        dn = bday[0] + "/" + b + "/" + bday[4];
                    }


                }
                



                root.AppendChild(AddNewDonator.AddDonator(number, genero, firstName, lastName, streetAddress, city, statefull, zipCode, email, username, password, telephone,
                   mothersMaiden, dn, age, occupation, company, vehicle, bloodType, kilograms, centimeters, guid, latitude, longitude, doc));
                MessageBox.Show("Donator added with success!");

                doc.Save(@"BaseDados.xml");

                 this.Close();

            }
            }
        }
    }
