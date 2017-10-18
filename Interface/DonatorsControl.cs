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

            listar = CreateListDonators.ListDonators(); // listar recebe a lista completa



            foreach (BloodDonator bd in listar.OrderBy(c => c.Number))
            {
                int id = bd.Number;
                String p_nome = bd.FirstName + "" + bd.LastName;
                String sexo = bd.Sexo;
                int idade = bd.Age;
                String g_sangue = bd.BloodType;
                long telefone = bd.TelephoneNumber;
                String cidade = bd.City;


                ListViewItem item = new ListViewItem(id.ToString());
                item.SubItems.Add(p_nome);
                item.SubItems.Add(sexo);
                item.SubItems.Add(idade.ToString());
                item.SubItems.Add(g_sangue);
                item.SubItems.Add(cidade);
                item.SubItems.Add(telefone.ToString());
                listView1.Items.Add(item);


            }



        }

        private int sortColumn = -1;


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
        {
            ItemComparer sorter = listView1.ListViewItemSorter as ItemComparer;
            if (sorter == null)
            {
                sorter = new ItemComparer(e.Column);
                sorter.Order = SortOrder.Ascending;
                listView1.ListViewItemSorter = sorter;
            }
            // if clicked column is already the column that is being sorted
            if (e.Column == sorter.Column)
            {
                // Reverse the current sort direction
                if (sorter.Order == SortOrder.Ascending)
                    sorter.Order = SortOrder.Descending;
                else
                    sorter.Order = SortOrder.Ascending;
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                sorter.Column = e.Column;
                sorter.Order = SortOrder.Ascending;
            }
            listView1.Sort();


        }

    }


    
}

