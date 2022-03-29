using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z5
{
    class Restoran
    {
	// polja + vežba lmao
        private string naziv;
        private string adresa;
        private List<Stavka> jelovnik;   // za vezbu uraditi zadatak koriscenjem recnika

	// properties
        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        public string Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }

	// konstruktor
        public Restoran(string naziv, string adresa)
        {
            Naziv = naziv;
            Adresa = adresa;

            jelovnik = new List<Stavka>();
        }

	// unos iz datoteke (tekstualne)
        public void Import(string file)
        {
            StreamReader sr = null;
            string naziv;
            double cena;
            string linija;

            try
            {
                sr = new StreamReader(file);

                // petlja za kreiranje stavki (u fajlu je jedan red - jedna stavka)
                while ((linija = sr.ReadLine()) != null)
                {
                	//razdvajanje po delimiteru |
                	string[] lineParts = linija.Split('|');

                	naziv = lineParts[0];
                	cena = Double.Parse(lineParts[lineParts.Length - 2]); 
			// ili lineParts[1], ovde je kao primer dato kako da se pristupi nekom elementu sa kraja

                	if (! NazivStavkePostoji(naziv)) 
			{
                        	jelovnik.Add(new Stavka(naziv, cena));
			}
            	}
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                if (sr != null) 
		{
                    sr.Close();
                }
            }
        }

	// sortiranje - homemade
        public void Sort()
        {
            Stavka tempI, tempJ;
            for (int i = 0; i < jelovnik.Count - 1; i++)
            {
                for (int j = i + 1; j < jelovnik.Count; j++)
                {
                    if (jelovnik[i].Cena < jelovnik[j].Cena)
                    {
                        tempI = jelovnik[i];
                        tempJ = jelovnik[j];
                        jelovnik.RemoveAt(j);
                        jelovnik.Insert(j, tempI);
                        jelovnik.RemoveAt(i);
                        jelovnik.Insert(i, tempJ);
                   }
                }
            }
        }

	/* - sortiramo cene koristeći ugrađeni Sort
        public void Sortiraj()
        {
            jelovnik.Sort((s1, s2) => s1.Cena.CompareTo(s2.Cena));
            jelovnik.Reverse();
        }
	*/

	// čuvanje u fajl (tekstualni)
        public void Export(string file)
        {
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(file);
                sw.WriteLine(this);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

	// ispis
        public override string ToString()
        {
	    // escape sequence za "" je \" (posle \ ide ")
            string str = "Restoran \"" + naziv + "\".\n"; 
            str += "Adresa: " + adresa + "\n\n";
            
	    if (jelovnik.Count == 0)
            {
                str += "Jelovnik je prazan";
            }
            else
            {
                str += "Jelovnik \n******************\n";
                foreach (Stavka s in jelovnik)
                    str += s + "\n";
                str += "******************\n";
            }
            return str;
        }

        // privatna pomocna metoda - nije obavezno
        private bool NazivStavkePostoji(string nazivStavke)
        {
            foreach (Stavka s in jelovnik)
            {
                if (s.Naziv == nazivStavke)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
