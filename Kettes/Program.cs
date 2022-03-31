using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 5. Projekt név: Kettes
// Készítsünk programot, mely tetszőleges tízes számrendszerbeli egész számot átvált kettes számrendszerbe.
namespace Kettes
{
    class Kszam
    {
        public Kszam() { }
        public void kksz()
        {
            string eredmeny;
            Console.WriteLine("Írj be egy számot 10-es számrendszerben!");
            int bekeres = int.Parse(Console.ReadLine());
            eredmeny = Convert.ToString(bekeres, 2);
            Console.WriteLine("Beírt szám kettes számrendszerben:\n{0}", eredmeny);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kszam megold = new Kszam();
            megold.kksz();
            Console.ReadKey();
        }
    }
}
