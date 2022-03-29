using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z5
{
    class Program
    {
        static void Main(string[] args)
        {
            Restoran r = new Restoran("Masinac", "Trg Dositeja Obradovica 4");
            Console.WriteLine(r);
            Console.WriteLine();

            //staviti fajl u folder FOLDER_PROJEKTA\bin\Debug
            r.Import("Jelovnik.txt");
            Console.WriteLine(r);
            Console.WriteLine();

            r.Sort();

            Console.WriteLine(r);

            r.Export("Jelovnik sredjen.txt");
        }
    }
}
