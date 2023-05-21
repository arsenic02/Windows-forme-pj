namespace pripremni_zadatak_1_lab_pj_winform
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fajlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gb = new System.Windows.Forms.GroupBox();
            this.rbTNG = new System.Windows.Forms.RadioButton();
            this.rbDizel = new System.Windows.Forms.RadioButton();
            this.rbBenzin = new System.Windows.Forms.RadioButton();
            this.chbAtest = new System.Windows.Forms.CheckBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.tbProizvodjac = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.nudZapremina = new System.Windows.Forms.NumericUpDown();
            this.dtpProizvodnja = new System.Windows.Forms.DateTimePicker();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudZapremina)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proizvodjac:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fajlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip";
            // 
            // fajlToolStripMenuItem
            // 
            this.fajlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.snimiToolStripMenuItem});
            this.fajlToolStripMenuItem.Name = "fajlToolStripMenuItem";
            this.fajlToolStripMenuItem.Size = new System.Drawing.Size(53, 29);
            this.fajlToolStripMenuItem.Text = "Fajl";
            // 
            // snimiToolStripMenuItem
            // 
            this.snimiToolStripMenuItem.Name = "snimiToolStripMenuItem";
            this.snimiToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.snimiToolStripMenuItem.Text = "Snimi";
            this.snimiToolStripMenuItem.Click += new System.EventHandler(this.snimiToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Zapremina motora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Datum proizvodnje:";
            // 
            // gb
            // 
            this.gb.Controls.Add(this.rbTNG);
            this.gb.Controls.Add(this.rbDizel);
            this.gb.Controls.Add(this.rbBenzin);
            this.gb.Location = new System.Drawing.Point(67, 245);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(319, 78);
            this.gb.TabIndex = 5;
            this.gb.TabStop = false;
            this.gb.Text = "Vrsta goriva";
            // 
            // rbTNG
            // 
            this.rbTNG.AutoSize = true;
            this.rbTNG.Location = new System.Drawing.Point(172, 39);
            this.rbTNG.Name = "rbTNG";
            this.rbTNG.Size = new System.Drawing.Size(67, 24);
            this.rbTNG.TabIndex = 2;
            this.rbTNG.TabStop = true;
            this.rbTNG.Text = "TNG";
            this.rbTNG.UseVisualStyleBackColor = true;
            this.rbTNG.Click += new System.EventHandler(this.rbTNG_Click);
            // 
            // rbDizel
            // 
            this.rbDizel.AutoSize = true;
            this.rbDizel.Location = new System.Drawing.Point(96, 39);
            this.rbDizel.Name = "rbDizel";
            this.rbDizel.Size = new System.Drawing.Size(69, 24);
            this.rbDizel.TabIndex = 1;
            this.rbDizel.TabStop = true;
            this.rbDizel.Text = "Dizel";
            this.rbDizel.UseVisualStyleBackColor = true;
            this.rbDizel.Click += new System.EventHandler(this.rbDizel_Click);
            // 
            // rbBenzin
            // 
            this.rbBenzin.AutoSize = true;
            this.rbBenzin.Location = new System.Drawing.Point(7, 39);
            this.rbBenzin.Name = "rbBenzin";
            this.rbBenzin.Size = new System.Drawing.Size(83, 24);
            this.rbBenzin.TabIndex = 0;
            this.rbBenzin.TabStop = true;
            this.rbBenzin.Text = "Benzin";
            this.rbBenzin.UseVisualStyleBackColor = true;
            this.rbBenzin.Click += new System.EventHandler(this.rbBenzin_Click);
            // 
            // chbAtest
            // 
            this.chbAtest.AutoSize = true;
            this.chbAtest.Location = new System.Drawing.Point(67, 351);
            this.chbAtest.Name = "chbAtest";
            this.chbAtest.Size = new System.Drawing.Size(102, 24);
            this.chbAtest.TabIndex = 6;
            this.chbAtest.Text = "Ima atest";
            this.chbAtest.UseVisualStyleBackColor = true;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(67, 438);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(413, 124);
            this.listBox.TabIndex = 7;
            this.listBox.DoubleClick += new System.EventHandler(this.listBox_DoubleClick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(67, 395);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 31);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // tbProizvodjac
            // 
            this.tbProizvodjac.Location = new System.Drawing.Point(163, 67);
            this.tbProizvodjac.Name = "tbProizvodjac";
            this.tbProizvodjac.Size = new System.Drawing.Size(223, 26);
            this.tbProizvodjac.TabIndex = 9;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(163, 107);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(223, 26);
            this.tbModel.TabIndex = 10;
            // 
            // nudZapremina
            // 
            this.nudZapremina.DecimalPlaces = 3;
            this.nudZapremina.Location = new System.Drawing.Point(163, 157);
            this.nudZapremina.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudZapremina.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudZapremina.Name = "nudZapremina";
            this.nudZapremina.Size = new System.Drawing.Size(223, 26);
            this.nudZapremina.TabIndex = 11;
            this.nudZapremina.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // dtpProizvodnja
            // 
            this.dtpProizvodnja.Location = new System.Drawing.Point(165, 195);
            this.dtpProizvodnja.Name = "dtpProizvodnja";
            this.dtpProizvodnja.Size = new System.Drawing.Size(221, 26);
            this.dtpProizvodnja.TabIndex = 12;
            // 
            // sfd
            // 
            this.sfd.DefaultExt = "txt";
            this.sfd.Filter = "Tekstualni fajl(*.txt)|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 574);
            this.Controls.Add(this.dtpProizvodnja);
            this.Controls.Add(this.nudZapremina);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbProizvodjac);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.chbAtest);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudZapremina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fajlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snimiToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.RadioButton rbTNG;
        private System.Windows.Forms.RadioButton rbDizel;
        private System.Windows.Forms.RadioButton rbBenzin;
        private System.Windows.Forms.CheckBox chbAtest;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox tbProizvodjac;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.NumericUpDown nudZapremina;
        private System.Windows.Forms.DateTimePicker dtpProizvodnja;
        private System.Windows.Forms.SaveFileDialog sfd;
    }
}

