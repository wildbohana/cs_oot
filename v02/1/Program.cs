using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z4
{
    class Program
    {
        static void Main(string[] args)
        {

            // Deljenje sa 0 
            int a = 5;
            int b = 0;

			// try catch za bilo koji izuzetak
            try
            {
                Console.WriteLine("a / b = {0}", a / b);
            }
            catch 	// ne navodi se koji izuzetak želimo da obradimo, već ovo izvršavamo u slučaju svakog izuzetka; ne preporučuje se
            {
                Console.WriteLine("Greška.");
            }

			// try catch - ispis informacija o izuzetku
            try
            {
                Console.WriteLine("a / b = {0}", a / b);
            }
            catch (Exception e)
            {
                Console.WriteLine("Greška: ");
                Console.WriteLine(e);
            }

			// try catch - za konkretan izuzetak
            try
            {
                Console.WriteLine("a / b = {0}", a / b);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Greška: deljenje sa nulom.");
            }



            // Format ulaza
            Console.WriteLine("Unesite identifikacioni broj: ");

            try
            {
                int id = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Uspeno ucitan broj");
            }
            catch (FormatException fe) 	// uvek prvo obrađujemo specifičniji izuzetak
            {
                Console.WriteLine("Desio se FormatException: ");
                Console.WriteLine(fe.StackTrace);
            }
            catch (Exception e)			// na kraju je najopštiji izuzetak - Exception
            {
                Console.WriteLine("Desio se Exception: ");
                Console.WriteLine(e.StackTrace);
            }
            finally						// deo koda koji se uvek izvršava
            {
                Console.WriteLine("Program je zavrsen.");
                Console.ReadLine();
            }

        }
    }
}
