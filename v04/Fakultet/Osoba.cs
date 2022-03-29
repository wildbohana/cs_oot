using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Osoba
    {
		// polja
        private string ime;
        private string prezime;

        // properties
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }

        // prazan konstruktor
        public Osoba()
        {
            Ime = "";
            Prezime = "";
        }

		// konstruktor sa parametrima
        public Osoba(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }

        // redefinisati metodu ToString
        public override string ToString()
        {
            return "Ime: " + Ime + ", prezime: " + Prezime;
        }

        // redefinisati metodu Equals
        public override bool Equals(object obj)
        {
            Osoba o = (Osoba)obj;

            if (obj == null)
                return false;
            else
                return (o.Ime.Equals(ime) && o.prezime.Equals(prezime));
        }

    }
}
