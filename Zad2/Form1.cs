using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad2_winform_racunarske_komponente
{
    public partial class Form1 : Form
    {
        private List<Komponenta> komponente;
        public Form1()
        {
            InitializeComponent();
            komponente = new List<Komponenta>();
        }
        //DODATO U DESIGNER
       //  this.dateTimePicker.CustomFormat = "dd.MM";
         //   dateTimePicker.Format = DateTimePickerFormat.Custom;//dodao sam
        public void IzObjektaUKontrole(Komponenta k)
        {
            tbProizvodjac.Text = k.Proizvodjac;
            tbNaziv.Text = k.Naziv;
            dateTimePicker.Value = k.DatumProizvodnje;
            nudCena.Value = (decimal)k.Cena;
            //cmbVrstaKomponente.Text = k.VrstaKomponente;
            IzaberiKomponentu(k.VrstaKomponente);
            nudKapacitet.Value = (decimal)k.Kapacitet;
            nudRadniTakt.Value = (decimal)k.RadniTakt;

        }
        public  void IzKontrolaUObjekte(Komponenta k)
        {
            k.Proizvodjac = tbProizvodjac.Text;
            k.Naziv = tbNaziv.Text;
            k.DatumProizvodnje = dateTimePicker.Value;
            k.Cena = (float)nudCena.Value;
            k.VrstaKomponente = (VrstaKomponente)Enum.Parse(typeof(VrstaKomponente), cmbVrstaKomponente.Text);
            k.Kapacitet = (float)nudKapacitet.Value;
            k.RadniTakt = (float)nudRadniTakt.Value;

        }
        private void IzaberiKomponentu(VrstaKomponente v)
        {
            //if(VrstaKomponente.Memorija==v)
                
            
            switch(v)
            {
                case VrstaKomponente.Memorija:
                    cmbVrstaKomponente.Text = "Memorija";
                    nudKapacitet.Enabled = true;
                    nudRadniTakt.Enabled = false;
                    break;
                case VrstaKomponente.Procesor:
                    cmbVrstaKomponente.Text = "Procesor";
                    nudKapacitet.Enabled = true;
                    nudRadniTakt.Enabled = false;
                    break;
                default:
                    break;
            }
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Komponenta novaDelka = new Komponenta();
            IzKontrolaUObjekte(novaDelka);
            komponente.Add(novaDelka);
            PrikaziListu();
        }
        private void PrikaziListu()
        {
            listBox.Items.Clear();
            listBox.Items.AddRange(komponente.ToArray());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbVrstaKomponente.Items.Add("Procesor");
            cmbVrstaKomponente.Items.Add("Memorija");
        }

        private void cmbVrstaKomponente_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbVrstaKomponente.Text == "Procesor")
            {
                nudKapacitet.Enabled = false;
                nudRadniTakt.Enabled = true;
            }
                
            else
            {
                nudKapacitet.Enabled = true;
                nudRadniTakt.Enabled = false;
            }
        }

        private void listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox.SelectedIndex != -1)
                IzObjektaUKontrole(komponente[listBox.SelectedIndex]);
        }
    }
}
