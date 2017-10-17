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


            //XmlDocument doc = new XmlDocument();
            /*
            XmlNodeList tudo;
            
            tudo = doc.SelectNodes("//Donator");
            XmlNodeList primeiro_nome;
            XmlNodeList ultimo_nome;
            XmlNodeList id;
            XmlNode root = doc.DocumentElement;
            */
            //1º e 2º nome na mesma coluna


            /*
            primeiro_nome = root.SelectNodes("//Donator/Primeiro_Nome");
            ultimo_nome = root.SelectNodes("//Donator/Ultimo_Nome");
            id = root.SelectNodes("//Donator/@id");
            */

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
            listView1.Sorting = SortOrder.Ascending;

            XDocument doc = XDocument.Load(@"teste2.xml");

            foreach (var dm in doc.Descendants("Donator"))
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                dm.Attribute("id").Value,
                dm.Element("Sexo").Value,
                dm.Element("Primeiro_Nome").Value +" "+ dm.Element("Ultimo_Nome").Value,
                dm.Element("Idade").Value,
                dm.Element("Tipo_Sanguineo").Value,
                dm.Element("Telefone").Value,
                dm.Element("Cidade").Value
                });
                listView1.Items.Add(item);
            }



        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
    }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

