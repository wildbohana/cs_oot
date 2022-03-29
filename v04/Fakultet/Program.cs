using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Studenti.txt";
            string text = LoadFromFile(path);

            Fakultet f = new Fakultet();
            f.UpisiStudente(text);

			f.SortirajStudente();

			string upis = "Sortirani.txt";
			SaveToFile(f.ToString(), upis);
			
            Console.ReadLine();
        }

        // unos iz fajla
        public static string LoadFromFile(string path)
        {
            StreamReader sr = null;
            string linija;
            string povratnaVrednost = "";

            try
            {
                sr = new StreamReader(path);
                while ((linija = sr.ReadLine()) != null)
                {
                    povratnaVrednost += linija;
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return povratnaVrednost;
        }

        // string 1 - string koji se upisuje
        // string 2 - putanja na koju se upisuje string
        public static void SaveToFile(string string1, string string2)
        {
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(string2);
				sw.WriteLine(string1);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
