using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.Collections;

namespace Interface
{
    public partial class DonatorsControl : UserControl
    {
       

        public DonatorsControl()
        {
            InitializeComponent();
            
            

                
                
            listView1.View = View.Details;
            listView1.GridLines = true;

            // Add required columns
            listView1.Columns.Add("ID");
            listView1.Columns.Add("Sexo");
            listView1.Columns.Add("Nome");
            listView1.Columns.Add("Idade");
            listView1.Columns.Add("Grupo Sanguineo");
            listView1.Columns.Add("Telefone");
            listView1.Columns.Add("Cidade");
           // listView1.Sorting = SortOrder.Ascending;

            



        }

       
           
        

   

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.listView1.SelectedItems.Count == 0)
                return;

            string a = this.listView1.SelectedItems[0].Text;
            // int donatorsSize = donators.length;
            XmlDocument documento = new XmlDocument();
            documento.Load(@"teste2.xml");
            XmlNodeList donator;
            XmlNode root = documento.DocumentElement;
            donator = root.SelectNodes("//Donator[@id = " + a +"]" );
            foreach (XmlNode item in donator)
            {
                MessageBox.Show(item.InnerXml);

            }





        }

        private void listView1_ColumnClick(object sender,System.Windows.Forms.ColumnClickEventArgs e)
        {
            this.listView1.ListViewItemSorter = new ListViewItemComparer(e.Column);
           
        
    }

    }
    class ListViewItemComparer : IComparer

    {

        private int col;

        public ListViewItemComparer()

        {

            col = 0;

        }

        public ListViewItemComparer(int column)

        {

            col = column;

        }

        public int Compare(object x, object y)

        {

            return String.Compare(((ListViewItem)y).SubItems[col].Text, ((ListViewItem)x).SubItems[col].Text);

        }

    }

}

