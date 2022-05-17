using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 5. Projekt név: Kettes
// Készítsünk programot, mely tetszőleges tízes számrendszerbeli egész számot átvált kettes számrendszerbe.
namespace Kettes
{
    public class Kszam
    {
        private string eredmeny = string.Empty;
        private int bekeres = 0;

        public Kszam(int bekeres) { this.bekeres = bekeres; }
        public string kksz()
        {
            eredmeny = Convert.ToString(this.bekeres, 2);
            Console.WriteLine("Beírt szám kettes számrendszerben:\n{0}", eredmeny);
            return eredmeny;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írj be egy számot 10-es számrendszerben!");
            Kszam megold = new Kszam(int.Parse(Console.ReadLine()));
            megold.kksz();
            Console.ReadKey();
        }
    }
}
