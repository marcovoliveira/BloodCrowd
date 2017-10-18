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



            List<BloodDonator> listar = new List<BloodDonator>();

            listar = CreateListDonators.ListDonators();  // listar recebe a lista completa

            // MessageBox.Show(Convert.ToString(listar.Count));  // so para mostrar que tenho todos na lista
            ListView listView1 = new ListView();
            listView1.View = View.Details;
            listView1.GridLines = true;

            // Add required columns


            ListViewItem item1 = new ListViewItem("ID");
            ListViewItem item2 = new ListViewItem("Sexo");
            ListViewItem item3 = new ListViewItem("Nome");
            ListViewItem item4 = new ListViewItem("Idade");
            ListViewItem item5 = new ListViewItem("Grupo Sanguíneo");
            ListViewItem item6 = new ListViewItem("Telefone");
            ListViewItem item7 = new ListViewItem("Cidade");

            /*  listView1.Columns.Add("ID");
              listView1.Columns.Add("Sexo");
              listView1.Columns.Add("Nome");
              listView1.Columns.Add("Idade");
              listView1.Columns.Add("Grupo Sanguineo");
              listView1.Columns.Add("Telefone");
              listView1.Columns.Add("Cidade");
              */
            // listView1.Sorting = SortOrder.Ascending;

            // Aqui quero que imprimas a lista com o nome "Listar" na list view que ja esta iniciada 

            foreach (BloodDonator bd in listar)
            {
                int id = bd.Number;
                String p_nome = bd.FirstName + "" + bd.LastName;
                String sexo = bd.Sexo;
                int idade = bd.Age;
                String g_sangue = bd.BloodType;
                long telefone = bd.TelephoneNumber;
                String cidade = bd.City;

                item1.SubItems.Add(id.ToString());
                item2.SubItems.Add(p_nome);
                item3.SubItems.Add(sexo);
                item4.SubItems.Add(idade.ToString());
                item5.SubItems.Add(g_sangue);
                item6.SubItems.Add(telefone.ToString());
                item7.SubItems.Add(cidade);


            }





        }







        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            /* if (this.listView1.SelectedItems.Count == 0)
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
             */




        }

        private void listView1_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
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
