using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_zad_winforme_film
{
    public partial class Form1 : Form
    {
        private List<Film> filmovi;
        public Form1()
        {
            InitializeComponent();
            filmovi = new List<Film>();
        }
        private void IzKontrolaUObjekat(Film f)
        {
            f.Naslov = tbNaslov.Text;
            f.Reditelj = tbReditelj.Text;
            f.Ocena = (float)nudOcena.Value;
            f.DatumPremijere = dtpDatumPremijere.Value;
            f.Zanr = (Zanr)Enum.Parse(typeof(Zanr), cmbZanr.Text);
            f.MinUzrast = (int)(float)nudUzrast.Value;
        }
        private void IzObjektaUKontrole(Film f)
        {
            tbNaslov.Text = f.Naslov;
            tbReditelj.Text = f.Reditelj;
            nudOcena.Value = (decimal)f.Ocena;
            dtpDatumPremijere.Value = f.DatumPremijere;
            IzaberiZanr(f.Zanr);
            nudUzrast.Value = f.MinUzrast;
        }
        /*
        private string OdrediZanr()
        {
            string s=cmbZanr.Text;
            return s;
            
        }*/
        public void IzaberiZanr(Zanr z)
        {
            switch(z)
            {
                case Zanr.Bajka:
                    cmbZanr.Text = "Bajka";
                    break;
                case Zanr.Drama:
                    cmbZanr.Text = "Drama";
                    break;
                case Zanr.Horor:
                    cmbZanr.Text = "Horor";
                    break;
                case Zanr.Ratni:
                    cmbZanr.Text = "Ratni";
                    break;
                default:
                    break;
            }
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Film noviFilm = new Film();
            //IzObjektaUKontrole(noviFilm);
            IzKontrolaUObjekat(noviFilm);
            filmovi.Add(noviFilm);
            PrikaziListu();
        }
        private void PrikaziListu()
        {
            
            listBox1.Items.Clear();
            listBox1.Items.AddRange(filmovi.ToArray());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbZanr.Items.Add("Bajka");
            cmbZanr.Items.Add("Drama");
            cmbZanr.Items.Add("Horor");
            cmbZanr.Items.Add("Ratni");
        }

        private void cmbZanr_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbZanr.Text == "Bajka")
            {
                nudUzrast.Enabled = false;
            }
            else
                nudUzrast.Enabled = true;
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(listBox1.SelectedIndex!=-1)
            {
                Film izabraniFilm = (Film)listBox1.SelectedItem;

                PodaciOFilmucs dlg = new PodaciOFilmucs(izabraniFilm);
                dlg.ShowDialog();
                /*if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    PrikaziListu();
                    
                }*/
            }
        }
    }
}
