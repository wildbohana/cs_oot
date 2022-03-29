using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Fakultet
    {
        // polja
        private List<Student> studenti = new List<Student>();

        // prazan konstruktor
        public Fakultet()
        {
            studenti = new List<Student>();
        }

        // imeStudenta,prezimeStudenta,smer-brojIndeksa/godinaUpisa;

        // upis studenta
        public void UpisiStudente(string text)
        {
            string[] studentiTxt = text.Split(';');

            // foreach(string red in studentiTxt)
	    for (int i = 0; i < studentiTxt.Count() - 1; i++)
            {
                try
                {
                    string[] delovi = studentiTxt[i].Split(',');

                    string ime = delovi[0];
                    string prezime = delovi[1];
                    string[] kusur = delovi[2].Split('-');
                    string smer = kusur[0];
                    int broj = Int32.Parse(kusur[1].Split('/')[0]);
                    int godina = Int32.Parse(kusur[1].Split('/')[1]);

                    Student s = new Student(ime, prezime, smer, broj, godina);
                    studenti.Add(s);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
               
            }
        }

        // sortiranje studenata u rastućem redosledu
        // prvo sa najmanjom godinom upisa, pa onda po broju indeksa
        public void SortirajStudente()
        {
            Student tempI, tempJ;
            for (int i = 0; i < studenti.Count - 1; i++)
            {
                for (int j = i + 1; j < studenti.Count; j++)
                {
                    if ((studenti[i].GodinaUpisa > studenti[j].GodinaUpisa) || (studenti[i].BrIndeksa > studenti[j].BrIndeksa))
                    {
                        tempI = studenti[i];
                        tempJ = studenti[j];
                        studenti.RemoveAt(j);
                        studenti.Insert(j, tempI);
                        studenti.RemoveAt(i);
                        studenti.Insert(i, tempJ);
                   }
                }
            }
        }

	// redefinisati metodu ToString
	public override string ToString() 
	{
		string str = "";

		str += "========================================\n";
		str += "\tFakultet Tehničkih Nauka\t\n";
		str += "========================================\n\n";

		foreach (Student s in studenti)
		{
			str += s.ToString();
			str += "\n";
		}

		return str;
	}

    }
}
