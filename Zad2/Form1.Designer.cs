using System.Windows.Forms;

namespace Zad2_winform_racunarske_komponente
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
            this.label7 = new System.Windows.Forms.Label();
            this.tbProizvodjac = new System.Windows.Forms.TextBox();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nudCena = new System.Windows.Forms.NumericUpDown();
            this.cmbVrstaKomponente = new System.Windows.Forms.ComboBox();
            this.nudRadniTakt = new System.Windows.Forms.NumericUpDown();
            this.nudKapacitet = new System.Windows.Forms.NumericUpDown();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadniTakt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKapacitet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proizvodjac:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum proizvodnje:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cena:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vrsta komponente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Radni takt[GHz]:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kapacitet[GB]:";
            // 
            // tbProizvodjac
            // 
            this.tbProizvodjac.Location = new System.Drawing.Point(206, 39);
            this.tbProizvodjac.Name = "tbProizvodjac";
            this.tbProizvodjac.Size = new System.Drawing.Size(200, 26);
            this.tbProizvodjac.TabIndex = 7;
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(206, 81);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(200, 26);
            this.tbNaziv.TabIndex = 8;
            // 
            // dateTimePicker
            // 
            // this.dateTimePicker.CustomFormat = "yyyy";//dodao sam
            this.dateTimePicker.CustomFormat = "dd.MM";
            dateTimePicker.Format = DateTimePickerFormat.Custom;//dodao sam
            this.dateTimePicker.Location = new System.Drawing.Point(206, 123);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker.TabIndex = 9;
            // 
            // nudCena
            // 
            this.nudCena.Location = new System.Drawing.Point(206, 168);
            this.nudCena.Name = "nudCena";
            this.nudCena.Size = new System.Drawing.Size(200, 26);
            this.nudCena.TabIndex = 10;
            // 
            // cmbVrstaKomponente
            // 
            this.cmbVrstaKomponente.FormattingEnabled = true;
            this.cmbVrstaKomponente.Location = new System.Drawing.Point(206, 206);
            this.cmbVrstaKomponente.Name = "cmbVrstaKomponente";
            this.cmbVrstaKomponente.Size = new System.Drawing.Size(200, 28);
            this.cmbVrstaKomponente.TabIndex = 11;
            this.cmbVrstaKomponente.SelectedValueChanged += new System.EventHandler(this.cmbVrstaKomponente_SelectedValueChanged);
            // 
            // nudRadniTakt
            // 
            this.nudRadniTakt.Location = new System.Drawing.Point(207, 251);
            this.nudRadniTakt.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudRadniTakt.Name = "nudRadniTakt";
            this.nudRadniTakt.Size = new System.Drawing.Size(199, 26);
            this.nudRadniTakt.TabIndex = 12;
            // 
            // nudKapacitet
            // 
            this.nudKapacitet.Location = new System.Drawing.Point(206, 296);
            this.nudKapacitet.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.nudKapacitet.Name = "nudKapacitet";
            this.nudKapacitet.Size = new System.Drawing.Size(200, 26);
            this.nudKapacitet.TabIndex = 13;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(64, 357);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 40);
            this.btnDodaj.TabIndex = 14;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(64, 419);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(509, 204);
            this.listBox.TabIndex = 15;
            this.listBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 644);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.nudKapacitet);
            this.Controls.Add(this.nudRadniTakt);
            this.Controls.Add(this.cmbVrstaKomponente);
            this.Controls.Add(this.nudCena);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.tbProizvodjac);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadniTakt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKapacitet)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbProizvodjac;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.NumericUpDown nudCena;
        private System.Windows.Forms.ComboBox cmbVrstaKomponente;
        private System.Windows.Forms.NumericUpDown nudRadniTakt;
        private System.Windows.Forms.NumericUpDown nudKapacitet;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListBox listBox;
    }
}

