using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class InstructionControl : UserControl
    {
        public InstructionControl()
        {
            InitializeComponent();
        }

        private void InstructionControl_Load(object sender, EventArgs e)
        {
            label3.Text =
                "To import a donators data in txt format chose the import button and when " +
                "the dialog appear chose the file.";
            label4.Text = "The program will give feedback about the status after import.";

            label6.Text = "To export donators you have to check the format you want to export (You can chose both).";
                                 
            label7.Text = "If you dont select you will export all the donators, if you select some of them you will only export the selected ones";

            label10.Text = "To view a donator detailed information you have to double click in listview at the donator you pretend to see.";

            label15.Text =
                "To add a donator you have to click on Add Donator button and fill the boxes (default values are presented for test proposes).";

            label16.Text =
                "To remove a donator you have to select the donator you want to remove in the list and click remove donator button.";

            label18.Text =
                "You can filter the list ascending and descending by clicking on the collums names or by compatibility on combo box";

            label8.Text = "You can search by name, age, blood type, gendre and bmi, when text is input on text box";


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
