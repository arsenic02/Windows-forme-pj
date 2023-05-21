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
    public partial class PodaciOFilmucs : Form
    {
        public PodaciOFilmucs()
        {
            InitializeComponent();
        }
        public PodaciOFilmucs(Film f)
        {
            InitializeComponent();
            lblNaslov.Text = f.Naslov;
            lblOcena.Text = f.Ocena.ToString();
            lblPremijera.Text = f.DatumPremijere.ToString("dd.MM");
            lblReditelj.Text = f.Reditelj;
            lblUzrast.Text = f.MinUzrast.ToString();
            IzaberiZanr(f.Zanr);
        }
        public void IzaberiZanr(Zanr z)
        {
            switch (z)
            {
                case Zanr.Bajka:
                    lblZanr.Text = "Bajka";
                    break;
                case Zanr.Drama:
                    lblZanr.Text = "Drama";
                    break;
                case Zanr.Horor:
                    lblZanr.Text = "Horor";
                    break;
                case Zanr.Ratni:
                    lblZanr.Text = "Ratni";
                    break;
                default:
                    break;
            }
        }
        /*
        private void IzObjektaUKontrole(Film f)
        {
            lblNaslov.Text = f.Naslov;
            lblOcena.Text = f.Ocena.ToString();
            lblPremijera.Text = f.DatumPremijere.ToString();
            lblReditelj.Text = f.Reditelj;
            lblUzrast.Text = f.MinUzrast.ToString();
            
            //lblZanr.Text = f.Zanr;PROBLEM
        }*/
        private void PodaciOFilmucs_Load(object sender, EventArgs e)
        {
            
        }
    }
}
