using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencijaZaposlenih
{
    class Zaposleni
	{
		// polja
		private int id;
		private string ime;
		private string prezime;
		private int dnevnica;
		private int radnihDana;
		private int bolovanje;

		// properties
		public int Id
		{
			get { return this.id; }
			set { this.id = value; }
		}

		public string Ime
		{
			get { return this.ime; }
			set { this.ime = value; }
		}

		public string Prezime
		{
			get { return this.prezime; }
			set { this.prezime = value; }
		}

		public int Dnevnica
		{
			get { return this.dnevnica; }
			set { this.dnevnica = value; }
		}

		public int RadnihDana
		{
			get { return this.radnihDana; }
			set { this.radnihDana = value; }
		}

		public int Bolovanje
		{
			get { return this.bolovanje; }
			set { this.bolovanje = value; }
		}

		// konstruktor sa parametrima
		public Zaposleni(int id, string ime, string prezime, int dnevnica, int radnihDana, int bolovanje)
		{
			this.id = id;
			this.ime = ime;
			this.prezime = prezime;
			this.dnevnica = dnevnica;
			this.radnihDana = radnihDana;
			this.bolovanje = bolovanje;
		}

		// ispis
		public override string ToString()
		{
			return "{0}. {1} {2}, {3} rsd dnevnica, {4} radnih dana, {5} bolovanja", Id, Ime, Prezime, Dnevnica, RadnihDana, Bolovanje;
		}

	}
}
