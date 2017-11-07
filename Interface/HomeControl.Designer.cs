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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Emergency = new System.Windows.Forms.Button();
            this.emergencyLabel = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chartDonatorsBT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bloodDonatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartDonatorsBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodDonatorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Emergency
            // 
            this.Emergency.Location = new System.Drawing.Point(277, 183);
            this.Emergency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Emergency.Name = "Emergency";
            this.Emergency.Size = new System.Drawing.Size(109, 66);
            this.Emergency.TabIndex = 0;
            this.Emergency.Text = "Emergency Emails";
            this.Emergency.UseVisualStyleBackColor = true;
            this.Emergency.Click += new System.EventHandler(this.Emergency_Click);
            // 
            // emergencyLabel
            // 
            this.emergencyLabel.AutoSize = true;
            this.emergencyLabel.Font = new System.Drawing.Font("Century Gothic", 8.8F);
            this.emergencyLabel.Location = new System.Drawing.Point(67, 138);
            this.emergencyLabel.Name = "emergencyLabel";
            this.emergencyLabel.Size = new System.Drawing.Size(316, 20);
            this.emergencyLabel.TabIndex = 1;
            this.emergencyLabel.Text = "Chose the types of blood to sent an email.";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(72, 183);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(199, 140);
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
            chartArea1.Name = "ChartArea1";
            this.chartDonatorsBT.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDonatorsBT.Legends.Add(legend1);
            this.chartDonatorsBT.Location = new System.Drawing.Point(467, 82);
            this.chartDonatorsBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartDonatorsBT.Name = "chartDonatorsBT";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDonatorsBT.Series.Add(series1);
            this.chartDonatorsBT.Size = new System.Drawing.Size(639, 425);
            this.chartDonatorsBT.TabIndex = 4;
            this.chartDonatorsBT.Text = "chart1";
            // 
            // bloodDonatorBindingSource
            // 
            this.bloodDonatorBindingSource.DataSource = typeof(Interface.BloodDonator);
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartDonatorsBT);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.emergencyLabel);
            this.Controls.Add(this.Emergency);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(1132, 535);
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
    }
}
