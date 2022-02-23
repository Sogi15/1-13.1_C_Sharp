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
            string szam = "",
                    szam1 = "";
            string[] ertek1 = new string[] { "nulla", "egy", "kettő", "három", "négy", "öt", "hat", "hét", "nyolc", "kilenc", "tiz" };
            string[] ertek2 = new string[] { "tizen", "huszon", "harminc", "negyven", "ötven", "hatvan", "hetven", "nyolcvan", "kilencven" };
            string[] ertek3 = new string[] { "száz", "kétszáz", "ezer", "millió" };
            Console.WriteLine("Kérlek írj be egy számot!");
            szam = Console.ReadLine();

            for (int i = 0; i < szam.Length; i++)
            {
                if (szam.Length == 1)
                {
                    switch (szam)
                    {
                        case "0": szam1 = ertek1[0]; break;
                        case "1": szam1 = ertek1[1]; break;
                        case "2": szam1 = ertek1[2]; break;
                        case "3": szam1 = ertek1[3]; break;
                        case "4": szam1 = ertek1[4]; break;
                        case "5": szam1 = ertek1[5]; break;
                        case "6": szam1 = ertek1[6]; break;
                        case "7": szam1 = ertek1[7]; break;
                        case "8": szam1 = ertek1[8]; break;
                        case "9": szam1 = ertek1[9]; break;
                    }
                }
            }
            Console.WriteLine("{0}", szam1);
            Console.ReadKey();
        }
    }

}
