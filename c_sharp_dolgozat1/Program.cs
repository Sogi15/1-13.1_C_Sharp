using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_dolgozat1
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam1 = 0,
                szam2 = 0;
            Console.WriteLine("Adj meg egy számot!");
            szam1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a második számot!");
            szam2 = int.Parse(Console.ReadLine());
            if (szam1 > 0 && szam2 > 0)
            {
                Console.WriteLine("A két szám közül egyik sem negatív");
            }
            else if (szam1 > 0 && szam2 < 0)
            {
                Console.WriteLine("A két szám közül a második negatív");
            }
            else if (szam1 < 0 && szam2 > 0)
            {
                Console.WriteLine("A két szám közül az első negatív");
            }
            else if (szam1 < 0 && szam2 < 0)
            {
                Console.WriteLine("Mind a két szám negatív");
            }
            Console.ReadKey();
        }
    }
}
