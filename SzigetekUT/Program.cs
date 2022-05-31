using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzigetekUT
{
    public class Island
    {
        private string cords;
        private int szigetszam = 0, szigethossz = 0;
        public Island(string cords)
        {
            this.cords = cords;
        }
        public void vizsgalat()
        {
            int index = 0;
            while (index < this.cords.Length)
            {
                if (this.cords[index] == '1')
                {
                    ++szigetszam;
                    int j = index;
                    int tmp = 0;
                    while (j < this.cords.Length && this.cords[j] == '1')
                    {
                        ++j;
                        ++tmp;
                    }
                    index = j;
                    if (tmp > szigethossz) { szigethossz = tmp; }
                }
                else
                {
                    ++index;
                }
            }
        }
        public int SzN()
        {
            vizsgalat();
            Console.WriteLine("Szigetek száma: {0}db",szigetszam);
            return szigetszam;
        }
        public int SzH()
        {
            vizsgalat();
            Console.WriteLine("Leghosszabb sziget: {0}km",szigethossz);
            return szigethossz;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írj be koordinátákat! 0-1es karakterek használatával");
            string sziget = Console.ReadLine();
            Island megold = new Island(sziget);
            megold.SzN();
            megold.SzH();
            Console.ReadKey();
        }
    }
}
