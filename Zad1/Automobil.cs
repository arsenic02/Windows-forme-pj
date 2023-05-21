using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pripremni_zadatak_1_lab_pj_winform
{
    public  enum VrstaGoriva
    {
        Benzin=0,
        Dizel,
        TNG
    }
    public class Automobil
    {
        private string proizvodjac,model;
        private float zapremina;//zapremina motora
        private DateTime datumProizvodnje;
        private VrstaGoriva vrstaGoriva;
        private bool atest;//ima atest,  nema atest
        

        public string Proizvodjac
        {
            get { return proizvodjac; }
            set { proizvodjac = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public float Zapremina
        {
            get { return zapremina; }
            set { zapremina = value; }
        }
        public DateTime DatumProizvodnje
        {
            get { return datumProizvodnje; }
            set { datumProizvodnje = value; }
        }
        public VrstaGoriva VrstaGoriva
        {
            get { return vrstaGoriva; }
            set { vrstaGoriva = value; }
        }
        public bool Atest
        {
            get { return atest; }
            set { atest = value; }
        }
        public override string ToString()
        {
            
            if(VrstaGoriva==VrstaGoriva.TNG && atest==false)
                return proizvodjac + " " + model + " " + zapremina +" "+vrstaGoriva+" "+" (nema atest) "+datumProizvodnje;
            else if(VrstaGoriva == VrstaGoriva.TNG && atest == true)
                return proizvodjac + " " + model + " " + zapremina + " " + vrstaGoriva + " " + " (ima atest) " + datumProizvodnje;
            else
                return proizvodjac + " " + model + " " + zapremina + " " + vrstaGoriva + " " + " " + datumProizvodnje;


        }
        public static void Snimi(string putanja,List<Automobil> cars)
        {
            try
            {
                using(StreamWriter sw=new StreamWriter(putanja))
                {
                    foreach(Automobil a in cars)
                    {//lepse je samo sa write i " "
                        sw.WriteLine(a.Proizvodjac);
                        sw.WriteLine(a.Model);
                        sw.WriteLine(a.Zapremina);
                        sw.WriteLine(a.DatumProizvodnje);
                        sw.WriteLine(a.VrstaGoriva);
                        sw.WriteLine(a.Atest);
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Greška prilikom snimanja liste automobila: " + e.Message, "Greška");
            
            }

        }
    }
}
