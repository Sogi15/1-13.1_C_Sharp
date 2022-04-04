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
            Console.WriteLine("írj be egy szót aminek a közepénél tükrözni szeretnéd!");
            String[] cd = { " " };
            beker = Console.ReadLine();
            beker = beker.ToLower();
            for (int i = beker.Length - 1; i > -1; i--)
            {
                szovegki += beker[i];
            }
            Console.WriteLine("A szöveg felénél tükrözve: {0}",szovegki);
            Console.ReadKey();
        }
    }
}
