namespace Interface
{
    partial class DonatorsControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.filterLabel = new System.Windows.Forms.Label();
            this.FilterBox = new System.Windows.Forms.ComboBox();
            this.addDonatorButton = new System.Windows.Forms.Button();
            this.removeDonatorButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.xmlCheckBox = new System.Windows.Forms.CheckBox();
            this.jsonCheckBox = new System.Windows.Forms.CheckBox();
            this.compatibilityComboBox = new System.Windows.Forms.ComboBox();
            this.BloodTypelabel = new System.Windows.Forms.Label();
            this.noteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader7,
            this.columnHeader4,
            this.columnHeader8});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(671, 565);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 128;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sexo";
            this.columnHeader3.Width = 84;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Idade";
            this.columnHeader7.Width = 84;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Grupo Sanguineo";
            this.columnHeader4.Width = 129;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "IMC";
            this.columnHeader8.Width = 86;
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(848, 174);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(207, 22);
            this.SearchBox.TabIndex = 1;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(749, 174);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(81, 23);
            this.searchLabel.TabIndex = 2;
            this.searchLabel.Text = "Search:";
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLabel.Location = new System.Drawing.Point(763, 123);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(67, 23);
            this.filterLabel.TabIndex = 3;
            this.filterLabel.Text = "Filter:";
            // 
            // FilterBox
            // 
            this.FilterBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.FilterBox.FormattingEnabled = true;
            this.FilterBox.Location = new System.Drawing.Point(848, 123);
            this.FilterBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilterBox.Name = "FilterBox";
            this.FilterBox.Size = new System.Drawing.Size(207, 24);
            this.FilterBox.TabIndex = 4;
            this.FilterBox.SelectedIndexChanged += new System.EventHandler(this.FilterBox_SelectedIndexChanged);
            // 
            // addDonatorButton
            // 
            this.addDonatorButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.addDonatorButton.Location = new System.Drawing.Point(752, 241);
            this.addDonatorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addDonatorButton.Name = "addDonatorButton";
            this.addDonatorButton.Size = new System.Drawing.Size(341, 68);
            this.addDonatorButton.TabIndex = 5;
            this.addDonatorButton.Text = "Add Donator";
            this.addDonatorButton.UseVisualStyleBackColor = true;
            this.addDonatorButton.Click += new System.EventHandler(this.addDonatorButton_Click);
            // 
            // removeDonatorButton
            // 
            this.removeDonatorButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.removeDonatorButton.Location = new System.Drawing.Point(752, 315);
            this.removeDonatorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeDonatorButton.Name = "removeDonatorButton";
            this.removeDonatorButton.Size = new System.Drawing.Size(341, 68);
            this.removeDonatorButton.TabIndex = 6;
            this.removeDonatorButton.Text = "Remove Donator";
            this.removeDonatorButton.UseVisualStyleBackColor = true;
            this.removeDonatorButton.Click += new System.EventHandler(this.removeDonatorButton_Click);
            // 
            // importButton
            // 
            this.importButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importButton.Location = new System.Drawing.Point(752, 389);
            this.importButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(341, 68);
            this.importButton.TabIndex = 7;
            this.importButton.Text = "Import Data";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.exportButton.Location = new System.Drawing.Point(752, 463);
            this.exportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(341, 68);
            this.exportButton.TabIndex = 8;
            this.exportButton.Text = "Export Data";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(677, 537);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(45, 21);
            this.statusLabel.TabIndex = 10;
            this.statusLabel.Text = "Error";
            // 
            // xmlCheckBox
            // 
            this.xmlCheckBox.AutoSize = true;
            this.xmlCheckBox.Location = new System.Drawing.Point(968, 537);
            this.xmlCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xmlCheckBox.Name = "xmlCheckBox";
            this.xmlCheckBox.Size = new System.Drawing.Size(58, 21);
            this.xmlCheckBox.TabIndex = 11;
            this.xmlCheckBox.Text = "XML";
            this.xmlCheckBox.UseVisualStyleBackColor = true;
            this.xmlCheckBox.CheckedChanged += new System.EventHandler(this.xmlCheckBox_CheckedChanged);
            // 
            // jsonCheckBox
            // 
            this.jsonCheckBox.AutoSize = true;
            this.jsonCheckBox.Location = new System.Drawing.Point(1032, 537);
            this.jsonCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.jsonCheckBox.Name = "jsonCheckBox";
            this.jsonCheckBox.Size = new System.Drawing.Size(60, 21);
            this.jsonCheckBox.TabIndex = 11;
            this.jsonCheckBox.Text = "Json";
            this.jsonCheckBox.UseVisualStyleBackColor = true;
            this.jsonCheckBox.CheckedChanged += new System.EventHandler(this.jsonCheckBox_CheckedChanged);
            // 
            // compatibilityComboBox
            // 
            this.compatibilityComboBox.FormattingEnabled = true;
            this.compatibilityComboBox.Location = new System.Drawing.Point(848, 74);
            this.compatibilityComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.compatibilityComboBox.Name = "compatibilityComboBox";
            this.compatibilityComboBox.Size = new System.Drawing.Size(207, 24);
            this.compatibilityComboBox.TabIndex = 12;
            this.compatibilityComboBox.SelectedIndexChanged += new System.EventHandler(this.compatibilityComboBox_SelectedIndexChanged);
            // 
            // BloodTypelabel
            // 
            this.BloodTypelabel.AutoSize = true;
            this.BloodTypelabel.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.BloodTypelabel.Location = new System.Drawing.Point(683, 73);
            this.BloodTypelabel.Name = "BloodTypelabel";
            this.BloodTypelabel.Size = new System.Drawing.Size(148, 23);
            this.BloodTypelabel.TabIndex = 13;
            this.BloodTypelabel.Text = "Compatibility:";
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(930, 100);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(125, 17);
            this.noteLabel.TabIndex = 14;
            this.noteLabel.Text = "(Can receive from)";
            // 
            // DonatorsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.BloodTypelabel);
            this.Controls.Add(this.compatibilityComboBox);
            this.Controls.Add(this.jsonCheckBox);
            this.Controls.Add(this.xmlCheckBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.removeDonatorButton);
            this.Controls.Add(this.addDonatorButton);
            this.Controls.Add(this.FilterBox);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DonatorsControl";
            this.Size = new System.Drawing.Size(1132, 565);
            this.Load += new System.EventHandler(this.DonatorsControl_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DonatorsControl_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.ComboBox FilterBox;
        private System.Windows.Forms.Button addDonatorButton;
        private System.Windows.Forms.Button removeDonatorButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.CheckBox xmlCheckBox;
        private System.Windows.Forms.CheckBox jsonCheckBox;
        private System.Windows.Forms.ComboBox compatibilityComboBox;
        private System.Windows.Forms.Label BloodTypelabel;
        private System.Windows.Forms.Label noteLabel;
    }
}
