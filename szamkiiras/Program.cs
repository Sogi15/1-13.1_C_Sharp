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
            string[] ertek1 = new string[] {"egy","kettő","három","négy","öt","hat","hét","nyolc","kilenc","tiz"};
            string[] ertek2 = new string[] { "tizen", "huszon","harminc","negyven","ötven","hatvan"};

              
            Console.WriteLine("Kérlek írj be egy számot!");
            szam = int.Parse(Console.ReadLine());
            Console.WriteLine("asd");
            Console.ReadKey();
        }
    }
}
