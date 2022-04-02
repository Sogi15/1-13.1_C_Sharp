using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        class Palindrom
        {
            private string szovegbe, szovegki = String.Empty;
            private char[] karakterlanc;
            public Palindrom() { }
            public void bekeres()
            {
                Console.WriteLine("Írj be egy szöveget!");
                szovegbe = Console.ReadLine();
                Console.WriteLine("Beírt szöveg:\n{0}", szovegbe);
            }
            public void vizsgalat()
            {
                string szovegbeL = szovegbe.ToLower();
                szovegbe = String.Concat(szovegbeL.Where(c => !Char.IsWhiteSpace(c)));
                karakterlanc = szovegbe.ToCharArray();
                for (int i = szovegbe.Length - 1; i > -1; i--)
                {
                    szovegki += szovegbe[i];
                }
                if (szovegki == szovegbe) { Console.WriteLine("Ez egy Palindrom"); } else { Console.WriteLine("Ez nem egy palindrom!"); }
            }
        }
        static void Main(string[] args)
        {
            Palindrom pp = new Palindrom();
            pp.bekeres();
            pp.vizsgalat();
            Console.ReadKey();
        }
    }
}
