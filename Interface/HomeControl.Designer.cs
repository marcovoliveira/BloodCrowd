namespace Interface
{
    partial class HomeControl

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Emergency = new System.Windows.Forms.Button();
            this.emergencyLabel = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chartDonatorsBT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bloodDonatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartDonatorsBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodDonatorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Emergency
            // 
            this.Emergency.Location = new System.Drawing.Point(208, 149);
            this.Emergency.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Emergency.Name = "Emergency";
            this.Emergency.Size = new System.Drawing.Size(82, 54);
            this.Emergency.TabIndex = 0;
            this.Emergency.Text = "Emergency Emails";
            this.Emergency.UseVisualStyleBackColor = true;
            this.Emergency.Click += new System.EventHandler(this.Emergency_Click);
            // 
            // emergencyLabel
            // 
            this.emergencyLabel.AutoSize = true;
            this.emergencyLabel.Font = new System.Drawing.Font("Century Gothic", 8.8F);
            this.emergencyLabel.Location = new System.Drawing.Point(50, 112);
            this.emergencyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emergencyLabel.Name = "emergencyLabel";
            this.emergencyLabel.Size = new System.Drawing.Size(257, 17);
            this.emergencyLabel.TabIndex = 1;
            this.emergencyLabel.Text = "Chose the types of blood to sent an email.";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(54, 149);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(150, 109);
            this.checkedListBox1.TabIndex = 2;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // chartDonatorsBT
            // 
            this.chartDonatorsBT.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.chartDonatorsBT.BackImageTransparentColor = System.Drawing.SystemColors.ButtonFace;
            this.chartDonatorsBT.BorderlineColor = System.Drawing.SystemColors.ButtonFace;
            chartArea2.Name = "ChartArea1";
            this.chartDonatorsBT.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartDonatorsBT.Legends.Add(legend2);
            this.chartDonatorsBT.Location = new System.Drawing.Point(350, 67);
            this.chartDonatorsBT.Name = "chartDonatorsBT";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartDonatorsBT.Series.Add(series2);
            this.chartDonatorsBT.Size = new System.Drawing.Size(479, 345);
            this.chartDonatorsBT.TabIndex = 4;
            this.chartDonatorsBT.Text = "chart1";
            this.chartDonatorsBT.Click += new System.EventHandler(this.chartDonatorsBT_Click_1);
            // 
            // bloodDonatorBindingSource
            // 
            this.bloodDonatorBindingSource.DataSource = typeof(Interface.BloodDonator);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.label1.Location = new System.Drawing.Point(370, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Graphic of blood donators per blood type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartDonatorsBT);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.emergencyLabel);
            this.Controls.Add(this.Emergency);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(849, 435);
            this.Load += new System.EventHandler(this.HomeControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDonatorsBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodDonatorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Emergency;
        private System.Windows.Forms.Label emergencyLabel;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.BindingSource bloodDonatorBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDonatorsBT;
        private System.Windows.Forms.Label label1;
    }
}
