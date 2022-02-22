using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamkiiras
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = 0;

            Console.WriteLine("Kérlek írj be egy számot!");
            szam = int.Parse(Console.ReadLine());
            switch (szam)
            {
                case 1:
                    Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
