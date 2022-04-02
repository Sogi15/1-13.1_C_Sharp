using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tukor
{
    class Program
    {
        static void Main(string[] args)
        {
            string beker, szovegki = String.Empty;
            Console.WriteLine("írj be egy szót aminek a közepénél tükrözni szeretnéd! (szóköz nélkül!)");
            String[] cd = { " " };
            beker = Console.ReadLine();
            beker = beker.ToLower();
            beker = String.Concat(beker.Where(c => !Char.IsWhiteSpace(c)));
            string first = beker.Substring(0, (int)(beker.Length / 2));
            string last = beker.Substring((int)(beker.Length / 2), (int)(beker.Length / 2));
            for (int i = first.Length - 1; i > -1; i--)
            {
                szovegki += first[i];
            }
            szovegki = szovegki + last;
            Console.WriteLine("A szöveg felénél tükrözve: {0}",szovegki);
            Console.ReadKey();
        }
    }
}
