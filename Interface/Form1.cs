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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //FormBorderStyle = FormBorderStyle.None;
            //WindowState = FormWindowState.Maximized;
            SidePanel.Height = HomeButton.Height;
            SidePanel.Top = HomeButton.Top;
            homeControl1.BringToFront();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadFile.Devolver();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logoName_Click(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = HomeButton.Height;
            SidePanel.Top = HomeButton.Top;
            homeControl1.BringToFront();
        }

        private void DonnatorsButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = DonatorsButton.Height;
            SidePanel.Top = DonatorsButton.Top;
            donatorsControl1.BringToFront();
        }

        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = StatisticsButton.Height;
            SidePanel.Top = StatisticsButton.Top;
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = ImportButton.Height;
            SidePanel.Top = ImportButton.Top;
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = ExportButton.Height;
            SidePanel.Top = ExportButton.Top;
        }
    }
}
