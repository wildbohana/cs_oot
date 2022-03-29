using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencijaZaposlenih
{
    class Program
    {
        static void Main(string[] args)
        {
			Zaposleni z = new Zaposleni(1, "Marko", "Markovic", 2500, 5, 0);
			Console.WriteLine(z);
			Console.WriteLine();

			EvidencijaZaposlenih e = new EvidencijaZaposlenih("FTN", "Trg Dositeja Obradovica 6");

			Console.WriteLine("Ispisujem evidenciju zaposlenih: \n\n");
			e.UcitajZaposlene("Zaposleni.txt");
			Console.WriteLine(e);

			Console.WriteLine("Najbolji radnik tj. radnik sa najvecom platom: \n" + e.NajboljiRadnik());

			Console.ReadLine();
		}
    }
}
