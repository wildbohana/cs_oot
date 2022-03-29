using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencijaZaposlenih
{
    // interfejsi se implementiraju
    class EvidencijaZaposlenih : Izvestaj
	{
		// polja
		private Dictionary<int, Zaposleni> zaposleni;
		private string nazivFirme;
		private string adresa;

		// konstruktor sa parametrima
		public EvidencijaZaposlenih(string nazivFirme, string adresa)
		{
			this.nazivFirme = nazivFirme;
			this.adresa = adresa;

			zaposleni = new Dictionary<int, Zaposleni>();
		}

		// implementiranje metode iz interfejsa
		public int Plata(int id)
		{
			if (zaposleni.ContainsKey(id)) 
			{
				return (zaposleni[id].RadnihDana - zaposleni[id].Bolovanje) * zaposleni[id].Dnevnica;
			}
				
			return -1;				
		}

		// unos iz tekstualnog fajla
		public void UcitajZaposlene(string file)
		{
			StreamReader sr = null;
			string linija;

			try
			{
				sr = new StreamReader(file);
				FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);

				if (fs != null)
				{
					while ((linija = sr.ReadLine()) != null)
					{
						string[] lineParts = linija.Split('|');

						int id;
						string ime;
						string prezime;
						int dnevnica;
						int brRadnihDana;
						int bolovanje;

						id = Int32.Parse(lineParts[0]);
						ime = lineParts[1];
						prezime = lineParts[2];
						dnevnica = Int32.Parse(lineParts[3]);
						brRadnihDana = Int32.Parse(lineParts[4]);
						bolovanje = Int32.Parse(lineParts[5]);

						if (!zaposleni.ContainsKey(id)) 
						{
							zaposleni.Add(id, new Zaposleni(id, ime, prezime, dnevnica, brRadnihDana, bolovanje));
						}
					}
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("Greska prilikom ucitavanja iz fajla!\n");
				Console.WriteLine(e.Message);
			}
			finally
			{
				if (sr != null) 
				{
					sr.Close();
				}
			}
		}

		public Zaposleni NajboljiRadnik()
		{
			Zaposleni najbolji = zaposleni[1];
			foreach (int id in zaposleni.Keys)
			{
				if (Plata(id) > (Plata(najbolji.Id)))
				{	
					najbolji = zaposleni[id];
				}
			}
			return najbolji;
		}

		public override string ToString()
		{
			string str = "";
			str += "========================================\n";
			str += "\t" + nazivFirme + "\n\t" + adresa + "\n";
			str += "========================================\n";
			foreach (Zaposleni z in zaposleni.Values)
			{
				str += z.Id + ". " + z.Prezime + " " + z.Ime + " " + Plata(z.Id).ToString("##,#") + " rsd\n";
			}
			
			return str;
		}
		
	}
}
