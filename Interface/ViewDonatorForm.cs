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
            }
        }
    }
}
