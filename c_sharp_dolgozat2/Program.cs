using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_dolgozat2
{
    class Program
    {
        static void Main(string[] args)
        {
            string konyvcim = "";
            int oldalszam = 0;
            string[] terjedelem = new string[] { "rövid terjedelmű könyv ", "hosszú terjedelmű könyv " };

            do
            {
                Console.WriteLine("Add meg a könyv címét!");
                konyvcim = Console.ReadLine();
                if (konyvcim == "")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Add meg az oldalainak számát!");
                    oldalszam = int.Parse(Console.ReadLine());
                    if (oldalszam < 150)
                    {
                        Console.WriteLine("{0} {1}", konyvcim, terjedelem[0]);
                    }
                    else if (oldalszam > 150) 
                    {
                        Console.WriteLine("{0} {1}", konyvcim, terjedelem[1]);
                    }
                }
            } while (konyvcim != "");
        }
    }
}
