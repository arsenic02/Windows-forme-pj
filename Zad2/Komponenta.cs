using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2_winform_racunarske_komponente
{
    public enum VrstaKomponente
    {
        Procesor=0,
        Memorija
    }
     public class Komponenta
    {
        private string proizvodjac,naziv;
        private DateTime datumProizvodnje;//.ToString("yyyy");;treba samo godina da se prikaze
        private float cena;
        private  VrstaKomponente vrstaKomponente;
        private float radniTakt;
        private float kapacitet;

       // string godina = datumProizvodnje.ToString("yyyy");
        public string Proizvodjac
        {
            get { return proizvodjac; }
            set { proizvodjac = value; }
        }
        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }
        public DateTime DatumProizvodnje
        {
            get { return datumProizvodnje; }
            set { datumProizvodnje = value; }
        }
        public float Cena
        {
            get { return cena; }
            set { cena = value; }
        }
        public VrstaKomponente VrstaKomponente
        {
            get { return vrstaKomponente; }
            set { vrstaKomponente = value; }
        }
        public float RadniTakt
        {
            get { return radniTakt; }
            set { radniTakt = value; }
        }
        public float Kapacitet
        {
            get { return kapacitet; }
            set { kapacitet = value; }
        }

        public override string ToString()
        {
            if (VrstaKomponente ==VrstaKomponente.Memorija)
                return vrstaKomponente + ": " + proizvodjac + ", " + naziv +" " +kapacitet+" GB, " + datumProizvodnje.ToString("dd.MM") + ", Cena: " + cena + ", ";
            else
                return vrstaKomponente + ": " + proizvodjac + ", " + naziv +" "+radniTakt+ "GHz, " + datumProizvodnje.ToString("dd.MM") + ", Cena: " + cena + ", ";
        }
    }
}
