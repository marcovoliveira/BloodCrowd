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
    }
}
