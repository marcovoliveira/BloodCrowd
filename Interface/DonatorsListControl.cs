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
    public partial class DonatorsListControl : UserControl
    {
        private DataView dv;
        private DataTable dt;

        public DonatorsListControl()
        {
            InitializeComponent();
        }

        private void DonatorsListControl_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;

            dt = new DataTable();
            dt.Columns.Add("Nome");
            dt.Columns.Add("Sexo");
            dt.Columns.Add("Idade");
            dt.Columns.Add("GrupoSanguineo");
            dt.Columns.Add("IMC");

            var donators = CreateListDonators.ListDonators(); // listar recebe a lista completa

            CarregarDadosTabela(donators);
            dv = new DataView(dt);

            CarregarDataProcura(dv);

            comboBoxFilter.Items.Add("Nome");
            comboBoxFilter.Items.Add("Sexo");
            comboBoxFilter.Items.Add("Idade");
            comboBoxFilter.Items.Add("GrupoSanguineo");
            comboBoxFilter.Items.Add("IMC");
            comboBoxFilter.SelectedIndex = 0;
        }

        private void CarregarDadosTabela(List<BloodDonator> donators)
        {

            foreach (BloodDonator bd in donators.OrderBy(c => c.Number))
            {

                String p_nome = bd.FirstName + "" + bd.LastName;
                String sexo = bd.Sexo;
                int idade = bd.Age;
                String g_sangue = bd.BloodType;
                long telefone = bd.TelephoneNumber;
                String cidade = bd.City;
                double imc = bd.IMC;

                dt.Rows.Add(p_nome, sexo, idade, g_sangue, String.Format("{0:0.00}", imc));
            }
        }

        private void CarregarDataProcura(DataView dv)
        {
            listView1.Items.Clear();
            foreach (DataRow row in dv.ToTable().Rows)
            {
                listView1.Items.Add(new ListViewItem(new String[]
                    {row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString()}));
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format(comboBoxFilter.Text + " Like'%{0}%'", searchTextBox.Text);
            CarregarDataProcura(dv);
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format(comboBoxFilter.Text + " Like'%{0}%'", searchTextBox.Text);
            CarregarDataProcura(dv);
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
