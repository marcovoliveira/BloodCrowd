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
            GerarGrafico();

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

        private void GerarGrafico()
        {
            //carrega base de dados
            XmlDocument doc = new XmlDocument();
            doc.Load(@"BaseDados.xml");

            //seleciona todos os donators de cada tipo em nodelist
            XmlNodeList all = doc.SelectNodes("//Donator");
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
            int numeroABMenos = nodelistABMenos.Count;
            int numeroOmais = nodelistOMais.Count;
            int numeroOmenos = nodelistOMenos.Count;
            int todos = all.Count;

            //calcula percentagem
            double pnumeroAMais = (double)numeroAmais / (double)todos *100;
            double pnumeroAmenos = (double)numeroAmenos / (double)todos * 100;
            double pnumeroBmais = (double)numeroBmais / (double)todos * 100;
            double pnumeroBmenos = (double)numeroBMenos / (double)todos * 100;
            double pnumeroABmais = (double)numeroABmais / (double)todos * 100;
            double pnumeroABmenos = (double)numeroABMenos / (double)todos * 100;
            double pnumeroOmais = (double)numeroOmais / (double)todos * 100;
            double pnumeroOmenos = (double)numeroOmenos / (double)todos * 100;

            chartDonatorsBT.Series.Clear(); //limpar o grafico
            chartDonatorsBT.Series.Add("GraficoBloodDonors");
            chartDonatorsBT.Series["GraficoBloodDonors"].ChartType = SeriesChartType.Pie;

            chartDonatorsBT.BackImageTransparentColor = Color.Transparent;

            //coloca so 1 casa desimal
            double tirarCasasDecimaisAM = Math.Round(pnumeroAMais, 1);
            double tirarCasasDecimaisAm = Math.Round(pnumeroAmenos, 1);
            double tirarCasasDecimaisBM = Math.Round(pnumeroBmais, 1);
            double tirarCasasDecimaisBm = Math.Round(pnumeroBmenos, 1);
            double tirarCasasDecimaisABM = Math.Round(pnumeroABmais, 1);
            double tirarCasasDecimaisABm = Math.Round(pnumeroABmenos, 1);
            double tirarCasasaDecimaisOM = Math.Round(pnumeroOmais, 1);
            double tirarCasasDecimaisOm = Math.Round(pnumeroOmenos, 1);


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
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[0].LegendText = "A+" ;
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[1].LegendText = "A-" ;
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[2].LegendText = "B+" ;
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[3].LegendText = "B-" ;
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[4].LegendText = "AB+" ;
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[5].LegendText = "AB-" ;
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[6].LegendText = "O+" ;
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[7].LegendText = "O-" ;

            //Adiciono descrição
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[0].Label = Convert.ToString(tirarCasasDecimaisAM)+"%";
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[1].Label = Convert.ToString(tirarCasasDecimaisAm)+"%";
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[2].Label = Convert.ToString(tirarCasasDecimaisBM)+"%";
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[3].Label = Convert.ToString(tirarCasasDecimaisBm)+"%";
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[4].Label = Convert.ToString(tirarCasasDecimaisABM)+"%";
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[5].Label = Convert.ToString(tirarCasasDecimaisABm)+"%";
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[6].Label = Convert.ToString(tirarCasasaDecimaisOM)+"%";
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[7].Label = Convert.ToString(tirarCasasDecimaisOm)+"%";

            

            chartDonatorsBT.Series["GraficoBloodDonors"].Points[0].Color = System.Drawing.Color.Blue;
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[1].Color = System.Drawing.Color.Red;
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[2].Color = System.Drawing.Color.Yellow;
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[3].Color = System.Drawing.Color.Green;
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[4].Color = System.Drawing.Color.BlueViolet;
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[5].Color = System.Drawing.Color.Black;
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[6].Color = System.Drawing.Color.LightBlue;
            chartDonatorsBT.Series["GraficoBloodDonors"].Points[7].Color = System.Drawing.Color.PaleVioletRed;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void gerarGrafico_Click(object sender, EventArgs e)
        {
            



        }

        private void chartDonatorsBT_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
