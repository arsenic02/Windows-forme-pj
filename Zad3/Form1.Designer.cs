namespace _3_zad_winforme_film
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbNaslov = new System.Windows.Forms.TextBox();
            this.tbReditelj = new System.Windows.Forms.TextBox();
            this.nudOcena = new System.Windows.Forms.NumericUpDown();
            this.dtpDatumPremijere = new System.Windows.Forms.DateTimePicker();
            this.cmbZanr = new System.Windows.Forms.ComboBox();
            this.nudUzrast = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudOcena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUzrast)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naslov:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reditelj:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ocena:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum premijere:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zanr:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Minimalni uzrast:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(41, 309);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 32);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(41, 369);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(382, 164);
            this.listBox1.TabIndex = 7;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // tbNaslov
            // 
            this.tbNaslov.Location = new System.Drawing.Point(192, 29);
            this.tbNaslov.Name = "tbNaslov";
            this.tbNaslov.Size = new System.Drawing.Size(173, 26);
            this.tbNaslov.TabIndex = 8;
            // 
            // tbReditelj
            // 
            this.tbReditelj.Location = new System.Drawing.Point(192, 78);
            this.tbReditelj.Name = "tbReditelj";
            this.tbReditelj.Size = new System.Drawing.Size(173, 26);
            this.tbReditelj.TabIndex = 9;
            // 
            // nudOcena
            // 
            this.nudOcena.DecimalPlaces = 1;
            this.nudOcena.Location = new System.Drawing.Point(192, 122);
            this.nudOcena.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            65536});
            this.nudOcena.Name = "nudOcena";
            this.nudOcena.Size = new System.Drawing.Size(173, 26);
            this.nudOcena.TabIndex = 14;
            // 
            // dtpDatumPremijere
            // 
            this.dtpDatumPremijere.Location = new System.Drawing.Point(192, 171);
            this.dtpDatumPremijere.Name = "dtpDatumPremijere";
            this.dtpDatumPremijere.Size = new System.Drawing.Size(173, 26);
            this.dtpDatumPremijere.TabIndex = 15;
            // 
            // cmbZanr
            // 
            this.cmbZanr.FormattingEnabled = true;
            this.cmbZanr.Location = new System.Drawing.Point(192, 213);
            this.cmbZanr.Name = "cmbZanr";
            this.cmbZanr.Size = new System.Drawing.Size(173, 28);
            this.cmbZanr.TabIndex = 16;
            this.cmbZanr.SelectedValueChanged += new System.EventHandler(this.cmbZanr_SelectedValueChanged);
            // 
            // nudUzrast
            // 
            this.nudUzrast.Location = new System.Drawing.Point(192, 259);
            this.nudUzrast.Maximum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.nudUzrast.Name = "nudUzrast";
            this.nudUzrast.Size = new System.Drawing.Size(173, 26);
            this.nudUzrast.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 550);
            this.Controls.Add(this.nudUzrast);
            this.Controls.Add(this.cmbZanr);
            this.Controls.Add(this.dtpDatumPremijere);
            this.Controls.Add(this.nudOcena);
            this.Controls.Add(this.tbReditelj);
            this.Controls.Add(this.tbNaslov);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Glavna forma";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudOcena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUzrast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tbNaslov;
        private System.Windows.Forms.TextBox tbReditelj;
        private System.Windows.Forms.NumericUpDown nudOcena;
        private System.Windows.Forms.DateTimePicker dtpDatumPremijere;
        private System.Windows.Forms.ComboBox cmbZanr;
        private System.Windows.Forms.NumericUpDown nudUzrast;
    }
}

