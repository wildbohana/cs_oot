using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z5
{
    class Stavka
    {
	// polja
        private string naziv;
        private double cena;

	// properties
        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        public double Cena
        {
            get { return cena; }
            set { cena = value; }
        }

	// konstruktor
        public Stavka(string naziv, double cena)
        {
            Naziv = naziv;
            Cena = cena;
        }

	// ispis
        public override string ToString()
        {
            return Naziv + " " + Cena;
        }

    }
}
