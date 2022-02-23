using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_dolgozat4
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = 0,
                nagyobb = 0;
            do
            {
                Console.WriteLine("Írj be egy számot!");
                szam = int.Parse(Console.ReadLine());
                if (szam > nagyobb)
                {
                    nagyobb = szam;
                }
            } while (szam != 0);
            Console.WriteLine("A legnagyobb szám: {0}",nagyobb);
            Console.ReadKey();
        }
    }
}
