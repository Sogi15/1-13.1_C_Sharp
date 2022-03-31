using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamrendszer
{
    class Szamrendszer
    {
        public string bekeres;
        public Szamrendszer() { }
        public void Kettes()
        {
            Console.WriteLine("Írj be egy számot!");
            bekeres =Console.ReadLine();
            Console.WriteLine("Beírt szám kettes számrendszerben:\n{0}", Convert.ToInt32(bekeres, 2));
        }
        public void Nyolcas()
        {
            Console.WriteLine("Írj be egy számot!");
            bekeres = Console.ReadLine();
            Console.WriteLine("Beírt szám nyolcas számrendszerben:\n{0}", Convert.ToInt32(bekeres, 8));
        }
        public void Tizenhatos()
        {
            Console.WriteLine("Írj be egy számot!");
            bekeres = Console.ReadLine();
            Console.WriteLine("Beírt szám tizenhatos számrendszerben:\n{0}", Convert.ToInt32(bekeres, 16));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int valasz;
            Szamrendszer megold = new Szamrendszer();
            Console.WriteLine("Válasz hanyas számrendszerbe szeretnél átváltani 10-es számrándszerből! (2/8/16)");
            valasz = int.Parse(Console.ReadLine());
            if (valasz == 2)
            {
                megold.Kettes();
            }
            else if (valasz == 8)
            {
                megold.Nyolcas();
            }
            else if (valasz == 16)
            {
                megold.Tizenhatos();
            }
            Console.ReadKey();
        }
    }
}
