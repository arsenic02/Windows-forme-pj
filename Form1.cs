using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pripremni_zadatak_1_lab_pj_winform
{
    public partial class Form1 : Form
    {
        private List<Automobil> automobili;
        public Form1()
        {
            InitializeComponent();
            automobili = new List<Automobil>();
        }
        private VrstaGoriva OdrediGorivo()
        {
            if (rbBenzin.Checked)
                return VrstaGoriva.Benzin;
            else if (rbDizel.Checked)
                return VrstaGoriva.Dizel;
            else 
                return VrstaGoriva.TNG;
        }
        private void IzKontrolaUObjekat(Automobil a)
        {
            a.Proizvodjac = tbProizvodjac.Text;
            a.Model = tbModel.Text;
            a.Zapremina = (float)nudZapremina.Value;
            a.DatumProizvodnje = dtpProizvodnja.Value;
            a.VrstaGoriva = OdrediGorivo();
            a.Atest = chbAtest.Checked;//
        }
        private void IzObjektaUKontrole(Automobil a)
        {
            tbProizvodjac.Text = a.Proizvodjac;
            tbModel.Text = a.Model;
            nudZapremina.Value = (decimal)a.Zapremina;
            dtpProizvodnja.Value = a.DatumProizvodnje;
            CekirajDugmice(a.VrstaGoriva);
            chbAtest.Checked = a.Atest;
        }
        private void CekirajDugmice(VrstaGoriva gorivo)
        {
            switch(gorivo)
            {
                case VrstaGoriva.Benzin:
                    rbBenzin.Checked = true;
                    break;
                case VrstaGoriva.Dizel:
                    rbDizel.Checked = true;
                    break;
                case VrstaGoriva.TNG:
                    rbTNG.Checked = true;
                    break;
                default:
                    break;
                    
            }
        }
        private void PrikaziListu()
        {
            listBox.Items.Clear();
            listBox.Items.AddRange(automobili.ToArray());
        }

       

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Automobil noviAuto = new Automobil();
            IzKontrolaUObjekat(noviAuto);
            automobili.Add(noviAuto);
            PrikaziListu();
        }

        private void rbBenzin_Click(object sender, EventArgs e)
        {
            //chbAtest.Visible = false;
            chbAtest.Enabled = false;
        }

        private void rbDizel_Click(object sender, EventArgs e)
        {
            chbAtest.Enabled = false;
        }

        private void rbTNG_Click(object sender, EventArgs e)
        {
            chbAtest.Enabled = true;
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            if(listBox.SelectedIndex!=-1)
            {
                IzObjektaUKontrole(automobili[listBox.SelectedIndex]);
            }
        }

        private void snimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Automobil.Snimi(sfd.FileName, automobili);
            }
        }
    }
}
