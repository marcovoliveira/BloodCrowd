namespace Interface
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DateTimeLabel = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.Version = new System.Windows.Forms.Label();
            this.DonatorsButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.close = new System.Windows.Forms.Button();
            this.maximize = new System.Windows.Forms.Button();
            this.hide = new System.Windows.Forms.Button();
            this.logoName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.subTitle = new System.Windows.Forms.Label();
            this.homeControl1 = new Interface.HomeControl();
            this.donatorsControl1 = new Interface.DonatorsControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.DateTimeLabel);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.Version);
            this.panel1.Controls.Add(this.DonatorsButton);
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 821);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // DateTimeLabel
            // 
            this.DateTimeLabel.AutoSize = true;
            this.DateTimeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeLabel.ForeColor = System.Drawing.Color.White;
            this.DateTimeLabel.Location = new System.Drawing.Point(28, 692);
            this.DateTimeLabel.Name = "DateTimeLabel";
            this.DateTimeLabel.Size = new System.Drawing.Size(169, 23);
            this.DateTimeLabel.TabIndex = 9;
            this.DateTimeLabel.Text = "Date Time Label";
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Maroon;
            this.SidePanel.ForeColor = System.Drawing.Color.Maroon;
            this.SidePanel.Location = new System.Drawing.Point(1, 90);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(24, 85);
            this.SidePanel.TabIndex = 8;
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Version.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Version.Location = new System.Drawing.Point(63, 792);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(131, 20);
            this.Version.TabIndex = 7;
            this.Version.Text = "Version 1.00 2017";
            // 
            // DonatorsButton
            // 
            this.DonatorsButton.FlatAppearance.BorderSize = 0;
            this.DonatorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DonatorsButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonatorsButton.ForeColor = System.Drawing.Color.White;
            this.DonatorsButton.Location = new System.Drawing.Point(0, 201);
            this.DonatorsButton.Name = "DonatorsButton";
            this.DonatorsButton.Size = new System.Drawing.Size(256, 107);
            this.DonatorsButton.TabIndex = 7;
            this.DonatorsButton.Text = "Donators List";
            this.DonatorsButton.UseVisualStyleBackColor = true;
            this.DonatorsButton.Click += new System.EventHandler(this.DonnatorsButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Location = new System.Drawing.Point(0, 88);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(256, 107);
            this.HomeButton.TabIndex = 7;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Brown;
            this.flowLayoutPanel1.Controls.Add(this.close);
            this.flowLayoutPanel1.Controls.Add(this.maximize);
            this.flowLayoutPanel1.Controls.Add(this.hide);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(256, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1151, 36);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.flowLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.flowLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Dock = System.Windows.Forms.DockStyle.Top;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.Transparent;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(1115, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(33, 30);
            this.close.TabIndex = 9;
            this.close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click_1);
            // 
            // maximize
            // 
            this.maximize.FlatAppearance.BorderSize = 0;
            this.maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximize.Image = ((System.Drawing.Image)(resources.GetObject("maximize.Image")));
            this.maximize.Location = new System.Drawing.Point(1085, 3);
            this.maximize.Name = "maximize";
            this.maximize.Size = new System.Drawing.Size(24, 30);
            this.maximize.TabIndex = 10;
            this.maximize.UseVisualStyleBackColor = true;
            this.maximize.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // hide
            // 
            this.hide.Dock = System.Windows.Forms.DockStyle.Right;
            this.hide.FlatAppearance.BorderSize = 0;
            this.hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide.Image = ((System.Drawing.Image)(resources.GetObject("hide.Image")));
            this.hide.Location = new System.Drawing.Point(1053, 3);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(26, 30);
            this.hide.TabIndex = 11;
            this.hide.UseVisualStyleBackColor = true;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // logoName
            // 
            this.logoName.AutoSize = true;
            this.logoName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoName.Location = new System.Drawing.Point(405, 50);
            this.logoName.Name = "logoName";
            this.logoName.Size = new System.Drawing.Size(155, 28);
            this.logoName.TabIndex = 5;
            this.logoName.Text = "BloodCrowd";
            this.logoName.Click += new System.EventHandler(this.logoName_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(263, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // subTitle
            // 
            this.subTitle.AutoSize = true;
            this.subTitle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTitle.Location = new System.Drawing.Point(407, 85);
            this.subTitle.Name = "subTitle";
            this.subTitle.Size = new System.Drawing.Size(195, 18);
            this.subTitle.TabIndex = 5;
            this.subTitle.Text = "Blood Donators Database";
            this.subTitle.Click += new System.EventHandler(this.logoName_Click);
            // 
            // homeControl1
            // 
            this.homeControl1.Location = new System.Drawing.Point(263, 264);
            this.homeControl1.Name = "homeControl1";
            this.homeControl1.Size = new System.Drawing.Size(1199, 557);
            this.homeControl1.TabIndex = 7;
            this.homeControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.homeControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.homeControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // donatorsControl1
            // 
            this.donatorsControl1.Location = new System.Drawing.Point(256, 287);
            this.donatorsControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.donatorsControl1.Name = "donatorsControl1";
            this.donatorsControl1.Size = new System.Drawing.Size(1199, 532);
            this.donatorsControl1.TabIndex = 8;
            this.donatorsControl1.Load += new System.EventHandler(this.donatorsControl1_Load);
            this.donatorsControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.donatorsControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.donatorsControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 821);
            this.Controls.Add(this.logoName);
            this.Controls.Add(this.subTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.donatorsControl1);
            this.Controls.Add(this.homeControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label logoName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label subTitle;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Button DonatorsButton;
        private HomeControl homeControl1;
        private System.Windows.Forms.Panel SidePanel;
        private DonatorsControl donatorsControl1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button maximize;
        private System.Windows.Forms.Button hide;
        private System.Windows.Forms.Label DateTimeLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

