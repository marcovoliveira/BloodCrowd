using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Windows.Forms.DataVisualization.Charting;

namespace Interface
{
    public partial class HomeControl : UserControl
    {
        


        public HomeControl()
        {
            InitializeComponent();
            

            checkedListBox1.Items.Add("A+");
            checkedListBox1.Items.Add("A-");
            checkedListBox1.Items.Add("B+");
            checkedListBox1.Items.Add("B-");
            checkedListBox1.Items.Add("AB+");
            checkedListBox1.Items.Add("AB-");
            checkedListBox1.Items.Add("O+");
            checkedListBox1.Items.Add("O-");

             

        }

        private void HomeControl_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Emergency_Click(object sender, EventArgs e)
        {
            List<String> types = new List<String>();

            if (checkedListBox1.CheckedItems.Count != 0)
            {
                foreach (var item in checkedListBox1.CheckedItems)
                {
                    types.Add(Convert.ToString(item));
                }

                if (SendEmail.BloodTypeEmail(types) == true)
                {
                    MessageBox.Show("Emails successfully sent!");
                }
                else
                {
                    MessageBox.Show("Error in sending emails!");
                }
            }
            else
            {
                MessageBox.Show("Please chose the blood types you want to send the email!");
            }
            

            

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void gerarGrafico_Click(object sender, EventArgs e)
        {
            //carrega base de dados
            XmlDocument doc = new XmlDocument();
            doc.Load(@"BaseDados.xml");

            //seleciona todos os donators de cada tipo em nodelist
            XmlNodeList nodeListAMais = doc.SelectNodes("//Donator[Tipo_Sanguineo='A+']");
            XmlNodeList nodelistAMenos = doc.SelectNodes("//Donator[Tipo_Sanguineo='A-']");
            XmlNodeList nodelistBMais = doc.SelectNodes("//Donator[Tipo_Sanguineo='B+']");
            XmlNodeList nodelistBMenos = doc.SelectNodes("//Donator[Tipo_Sanguineo='B-']");
            XmlNodeList nodelistABMais = doc.SelectNodes("//Donator[Tipo_Sanguineo='AB+']");
            XmlNodeList nodelistABMenos = doc.SelectNodes("//Donator[Tipo_Sanguineo='AB-']");
            XmlNodeList nodelistOMais = doc.SelectNodes("//Donator[Tipo_Sanguineo='O+']");
            XmlNodeList nodelistOMenos = doc.SelectNodes("//Donator[Tipo_Sanguineo='O-']");

            //faz a contagem de donators por tipo de sangue
            int numeroAmais = nodeListAMais.Count;
            int numeroAmenos = nodelistAMenos.Count;
            int numeroBmais = nodelistBMais.Count;
            int numeroBMenos = nodelistBMenos.Count;
            int numeroABmais = nodelistABMais.Count;
            int numeroABMenos= nodelistABMenos.Count;
            int numeroOmais = nodelistOMais.Count;
            int numeroOmenos = nodelistOMenos.Count;
            
            
            
            chartDonatorsBT.Series.Clear(); //limpar o grafico
            chartDonatorsBT.Series.Add("GraficoBloodDonors");
            chartDonatorsBT.Series["GraficoBloodDonors"].ChartType = SeriesChartType.Pie;

            //Adiciono valores ao grafico
            chartDonatorsBT.Series["GraficoBloodDonors"].Points.Add(numeroAmais);
            chartDonatorsBT.Series["GraficoBloodDonors"].Points.Add(numeroAmenos);
            chartDonatorsBT.Series["GraficoBloodDonors"].Points.Add(numeroBmais);
            chartDonatorsBT.Series["GraficoBloodDonors"].Points.Add(numeroBMenos);
            chartDonatorsBT.Series["GraficoBloodDonors"].Points.Add(numeroABmais);
            chartDonatorsBT.Series["GraficoBloodDonors"].Points.Add(numeroABMenos);
            chartDonatorsBT.Series["GraficoBloodDonors"].Points.Add(numeroOmais);
            chartDonatorsBT.Series["GraficoBloodDonors"].Points.Add(numeroOmenos);

            //Adiciono legenda
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[0].LegendText = "A+";
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[1].LegendText = "A-";
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[2].LegendText = "B+";
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[3].LegendText = "B-";
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[4].LegendText = "AB+";
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[5].LegendText = "AB-";
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[6].LegendText = "O+";
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[7].LegendText = "O-";

            //Adiciono descrição
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[0].Label = "Tipo A+";
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[1].Label = "Tipo A-";
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[2].Label = "Tipo B+";
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[3].Label = "Tipo B-";
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[4].Label = "Tipo AB+";
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[5].Label = "Tipo AB-";
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[6].Label = "Tipo O+";
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[7].Label = "Tipo O-";

            

            chartDonatorsBT.Series["GraficoBloodDonors"].Points[0].Color = System.Drawing.Color.Blue;
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[1].Color = System.Drawing.Color.Red;
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[2].Color = System.Drawing.Color.Yellow;
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[3].Color = System.Drawing.Color.Green;
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[4].Color = System.Drawing.Color.BlueViolet;
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[5].Color = System.Drawing.Color.Black;
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[6].Color = System.Drawing.Color.LightBlue;
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[7].Color = System.Drawing.Color.PaleVioletRed;



        }

        private void chartDonatorsBT_Click(object sender, EventArgs e)
        {

        }
    }
}
