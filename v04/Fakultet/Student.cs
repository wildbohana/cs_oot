using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student : Osoba
    {
        // polja
        private Osoba osoba;
        private string smer;
        private int brIndeksa;
        private int godinaUpisa;

        // properties - samo za ova 3 polja 
        public string Smer { get => smer; set => smer = value; }
        public int BrIndeksa { get => brIndeksa; set => brIndeksa = value; }
        public int GodinaUpisa { get => godinaUpisa; set => godinaUpisa = value; }

        // konstrutkor sa parametrima
        public Student(string ime, string prezime, string smer, int brIndeksa, int godinaUpisa)
        {
            Ime = ime;
            Prezime = prezime;
            Smer = smer;
            BrIndeksa = brIndeksa;
            GodinaUpisa = godinaUpisa;
        }

        // prazan konstrutkor
        public Student() : base()
        {
	    // da li mi fali nešto ovde ?
        }

        // redefinisati metodu ToString
        public override string ToString()
        {
            return base.ToString() + ", " + Smer + "-" + BrIndeksa + "/" + GodinaUpisa;
        }

        // redefinisati metodu Equals
        public override bool Equals(object obj)
        {
            Student s = (Student)obj;

            if (s == null)
                return false;
            else
                if (s.smer.Equals(smer) && s.brIndeksa == this.brIndeksa && s.godinaUpisa == this.godinaUpisa)
                    return base.Equals(obj);

            return false;
        }

    }
}
