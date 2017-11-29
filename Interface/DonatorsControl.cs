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
using Interface.ServiceReference1;
using System.IO;

namespace Interface
{
    public partial class DonatorsControl : UserControl
    {
        


        private DataView dv;
        private DataTable dt;
        private int sortColumn = -1;

        public DonatorsControl()
        {
            InitializeComponent();  

        }
       
        private void DonatorsControl_Load(object sender, EventArgs e)
        {
            // Destalhes da listview 
            listView1.View = View.Details;
            ReloadListView();
           
            FilterBox.Items.Add("Nome");
            FilterBox.Items.Add("Sexo");
            FilterBox.Items.Add("Idade");
            FilterBox.Items.Add("GrupoSanguineo");
            FilterBox.Items.Add("IMC");
            FilterBox.SelectedIndex = 0;

            compatibilityComboBox.Items.Add("All");
            compatibilityComboBox.Items.Add("A+");
            compatibilityComboBox.Items.Add("A-");
            compatibilityComboBox.Items.Add("B+");
            compatibilityComboBox.Items.Add("B-");
            compatibilityComboBox.Items.Add("AB+");
            compatibilityComboBox.Items.Add("AB-");
            compatibilityComboBox.Items.Add("O+");
            compatibilityComboBox.Items.Add("O-");
            compatibilityComboBox.SelectedIndex = 0; 



        }
        //teste
         public static List<BloodDonator> ListaDonators()
            {


                // listar recebe a lista completa
                List<BloodDonator> donators = new List<BloodDonator>();
                donators = CreateListDonators.ListDonators();
                return donators; 
            }
       
       

        public void ReloadListView()
        {
            
            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Nome");
            dt.Columns.Add("Sexo");
            dt.Columns.Add("Idade");
            dt.Columns.Add("GrupoSanguineo");
            dt.Columns.Add("IMC");

            Service1Client client = new Service1Client();
            
            var donators = ListaDonators();

            if (donators.Count == 0)
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Please import data from a source file .txt!";
            }
            else
            {
                statusLabel.ForeColor = Color.Green;
                statusLabel.Text = "OK, " + donators.Count + " Donators Load.";
            }

            CarregarDadosTabela(donators);
            dv = new DataView(dt);

            CarregarDataProcura(dv);
        }

        private void CarregarDadosTabela(List<BloodDonator> donators)
        {

            foreach (BloodDonator bd in donators.OrderBy(c => c.Number))
            {
                int id = bd.Number;
                String p_nome = bd.FirstName + " " + bd.LastName;
                String sexo = bd.Sexo;
                int idade = bd.Age;
                String g_sangue = bd.BloodType;
                double imc = bd.IMC;

                dt.Rows.Add(id, p_nome, sexo, idade, g_sangue, String.Format("{0:0.00}", imc));
            }
        }

        private void compatibilityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (compatibilityComboBox.Text == "All")
            {
                dv.RowFilter = "";
                CarregarDataProcura(dv);
            }
            if (compatibilityComboBox.Text == "A+")
            {
                dv.RowFilter = "(GrupoSanguineo = 'A+') OR (GrupoSanguineo = 'A-') OR (GrupoSanguineo = 'O+') OR (GrupoSanguineo = 'O-')";
                CarregarDataProcura(dv);
            }
            if (compatibilityComboBox.Text == "A-")
            {
                dv.RowFilter = "(GrupoSanguineo = 'A-') OR (GrupoSanguineo = 'O-')";
                CarregarDataProcura(dv);
            }
            if (compatibilityComboBox.Text == "B+")
            {
                dv.RowFilter = "(GrupoSanguineo = 'B+') OR (GrupoSanguineo = 'B-')  OR (GrupoSanguineo = 'O-')OR (GrupoSanguineo = 'O+')";
                CarregarDataProcura(dv);
            }
            if (compatibilityComboBox.Text == "AB+")
            {
                dv.RowFilter = "(GrupoSanguineo = 'AB+') OR (GrupoSanguineo = 'AB-') OR (GrupoSanguineo = 'B+') OR (GrupoSanguineo = 'B-')" +
                               "OR (GrupoSanguineo = 'A+') OR (GrupoSanguineo = 'A-') OR (GrupoSanguineo = 'O+') OR (GrupoSanguineo = 'O-')";
                CarregarDataProcura(dv);
            }

            if (compatibilityComboBox.Text == "AB-")
            {
                dv.RowFilter = "(GrupoSanguineo = 'AB-') OR (GrupoSanguineo = 'B-') OR (GrupoSanguineo = 'A-') OR (GrupoSanguineo = 'O-')";
                CarregarDataProcura(dv);
            }
            if (compatibilityComboBox.Text == "O+")
            {
                dv.RowFilter = "(GrupoSanguineo = 'O+') OR (GrupoSanguineo = 'O-')";
                CarregarDataProcura(dv);
            }

            if (compatibilityComboBox.Text == "O-")
            {
                
            }

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchBox.Text == "male" && FilterBox.Text == "Sexo")
            {
                dv.RowFilter = "(Sexo ='Male')";
                CarregarDataProcura(dv);
            }
            else { 
            dv.RowFilter = string.Format(FilterBox.Text + " Like'%{0}%'", SearchBox.Text);
            CarregarDataProcura(dv);
            }
        }

        private void FilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchBox.Text == "male" && FilterBox.Text == "Sexo")
            {
                dv.RowFilter = "(Sexo ='Male')";
                CarregarDataProcura(dv);
            }
            else
            {
                dv.RowFilter = string.Format(FilterBox.Text + " Like '%{0}%'", SearchBox.Text);
            CarregarDataProcura(dv);
            }

        }

        private void CarregarDataProcura(DataView dv)
        {
            listView1.Items.Clear();
            foreach (DataRow row in dv.ToTable().Rows)
            {
                listView1.Items.Add(new ListViewItem(new String[]
                {
                    row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(),
                    row[4].ToString(), row[5].ToString()
                }));
            }
        }

        private void listView1_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
        {
            ItemComparer ordernar = listView1.ListViewItemSorter as ItemComparer;
            if (ordernar == null)
            {
                ordernar = new ItemComparer(e.Column);
                ordernar.Order = SortOrder.Ascending;
                listView1.ListViewItemSorter = ordernar;
            }
                // Se a coluna clicada ja for a que estiver a ser ordenada
            if (e.Column == ordernar.Column)
            {
                // Altera a direção da ordenação
                if (ordernar.Order == SortOrder.Ascending)
                    ordernar.Order = SortOrder.Descending;
                else
                    ordernar.Order = SortOrder.Ascending;
            }
            else
            {
                // Altera o numero da coluna que estamos a ordenar e mete por defeito a ordem ascendente. 
                ordernar.Column = e.Column;
                ordernar.Order = SortOrder.Ascending;
            }
            listView1.Sort();


        }

        private void importButton_Click(object sender, EventArgs e)
        {
            Service1Client client = new Service1Client();

     
            OpenFileDialog o = new OpenFileDialog();
            o.ShowDialog();
            o.DefaultExt = "*.txt";
            String nomefile = o.FileName;



          if( client.Devolver(nomefile)==false)
            {
                MessageBox.Show("Error parsing source file.");
            }
            else
            {
                MessageBox.Show("Data successfully load.");
            }
            
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            List<int> idSelecionado = new List<int>();
            int tipo = 3;
            

            if (xmlCheckBox.Checked && !jsonCheckBox.Checked)
            {
                tipo = 0;
            }
            else if (!xmlCheckBox.Checked && jsonCheckBox.Checked)
            {
                tipo = 1;
            }
            else if (xmlCheckBox.Checked && jsonCheckBox.Checked)
            {
                tipo = 2;
            }
            if (xmlCheckBox.Checked || jsonCheckBox.Checked)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    if (MessageBox.Show("Are you sure you want to export " + listView1.SelectedItems.Count +
                                        " donator(s) from blood donators database ?",
                            "Export donator!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                       
                        foreach (ListViewItem item in listView1.SelectedItems)
                        {

                            idSelecionado.Add(Convert.ToInt32(item.Text));
                        }
                        
                       
                        ExportDonators.ExportDonator(ListaDonators(), tipo, idSelecionado);
                       
                        listView1.SelectedItems.Clear();
                    }
                    else
                    {
                        listView1.SelectedItems.Clear();
                    }

                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to export all donators from blood donators database ?",
                            "Export donators!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        for (int i = 0; i < listView1.Items.Count; i++)
                        {
                            idSelecionado.Add(i);
                        }
                        ExportDonators.ExportDonator(ListaDonators(), tipo, idSelecionado);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a export format!");
            }
        }

        private void removeDonatorButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete " + listView1.SelectedItems.Count +
                                    " donator(s) from blood donators database ?",
                        "Delete donator!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (ListViewItem item in listView1.SelectedItems)
                    {
                        
                        if (!RemoveDonator.RemoverDonator(Convert.ToInt32(item.Text)))
                        { 
                            MessageBox.Show("Fail to delete donator!");

                        }
                    }
                    ReloadListView();
                }
            }
            else
            {
                MessageBox.Show("Please select a donator to delete!");
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            foreach (ListViewItem item in listView1.SelectedItems)
            {
              
                ViewDonatorForm viewDonatorForm = new ViewDonatorForm(item.Text);
               viewDonatorForm.ShowDialog();

            }
           
        }
        
        private void addDonatorButton_Click(object sender, EventArgs e)
        {
           
           

            AddDonatorForm addDonatorForm = new AddDonatorForm();
            addDonatorForm.ShowDialog();
            ReloadListView();
        }

        private void xmlCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            listView1.SelectedItems.Clear();
        }

        private void jsonCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            listView1.SelectedItems.Clear();
        }

        private void DonatorsControl_MouseClick(object sender, MouseEventArgs e)
        {
            listView1.SelectedItems.Clear();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }   
}

