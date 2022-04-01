using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            string szovegbe,szovegki=String.Empty;
            char[] karakterlanc;
            Console.WriteLine("Írj be egy szöveget!");
            szovegbe = Console.ReadLine();
            Console.WriteLine("Beírt szöveg:\n{0}",szovegbe);
            karakterlanc = szovegbe.ToCharArray();
            for (int i = szovegbe.Length - 1; i > -1; i--)
            {
                szovegki += szovegbe[i];
            }
            Console.WriteLine("Kiírt szöveg:\n{0}",szovegki);
            Console.ReadKey();
        }
    }
}
