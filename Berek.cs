using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA241118
{
    internal class Berek
    {
        private string nev;
        private bool neme = false;
        private string reszleg;
        private int belepes;
        private int ber;

        public Berek(string sor)
        {
            string[] v = sor.Split(';');
            nev = v[0];
            neme = v[1] == "férfi";
            reszleg = v[2];
            belepes = int.Parse(v[3]);
            ber = int.Parse(v[4]);
        }

        public string Nev { get => nev; set => nev = value; }
        public bool Neme { get => neme; set => neme = value; }
        public string Reszleg { get => reszleg; set => reszleg = value; }
        public int Belepes { get => belepes; set => belepes = value; }
        public int Ber { get => ber; set => ber = value; }
    }
}
