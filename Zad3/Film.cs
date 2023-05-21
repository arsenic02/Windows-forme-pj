using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_zad_winforme_film
{
    public enum Zanr
    {
        Drama=0,
        Ratni,
        Horor,
        Bajka
    }
    public class Film
    {
        private string naslov;
        private string reditelj;
        private float ocena;
        private DateTime datumPremijere;
        private Zanr zanr;
        private int minUzrast;//minimalni uzrast

        /*
        public Film(Film drugi)
        {
            this.naslov = drugi.naslov;
            this.reditelj = drugi.reditelj;
            this.ocena = drugi.ocena;
            this.datumPremijere = drugi.datumPremijere;
            this.zanr = drugi.zanr;
            this.minUzrast = drugi.minUzrast;
        }*/
        public string Naslov
        {
            get { return naslov; }
            set { naslov = value; }
        }
        public string Reditelj
        {
            get { return reditelj; }
            set { reditelj = value; }
        }
        public float Ocena
        {
            get { return ocena; }
            set { ocena = value; }
        }
        public DateTime DatumPremijere
        {
            get { return datumPremijere; }
            set { datumPremijere = value; }
        }
        public Zanr Zanr
        {
            get { return zanr; }
            set { zanr = value; }
        }
        public int MinUzrast
        {
            get { return minUzrast; }
            set { minUzrast = value; }
        }

        public override string ToString()
        {
            if (Zanr == Zanr.Bajka)
                return naslov + ", " + reditelj + ", " + ocena + ", " + zanr + ", " + datumPremijere.ToString("dd.MM");
            else
                return naslov + ", " + reditelj + ", " + ocena + ", " + zanr + " (prikladan za starije od "+minUzrast+"), " + datumPremijere.ToString("dd.MM");
        }
    }
}
