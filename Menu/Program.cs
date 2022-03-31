using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Menusor
    {
        private string m1 = "Első menüpont";
        private string m2 = "Második menüpont";
        private string m3 = "Harmadik menüpont";
        private string m4 = "Negyedik menüpont";
        public Menusor() { }
        public void menuk()
        {
                Console.WriteLine("1| {0}\n2| {1}\n3| {2}\n4| {3}\n5| Kilépés", m1, m2, m3, m4);
                int szam = int.Parse(Console.ReadLine());
                if (szam == 1)
                {
                    Console.WriteLine("Válaszott menü:\n{0}", m1);
                }
                else if (szam == 2)
                {
                    Console.WriteLine("Válaszott menü:\n{0}", m2);
                }
                else if (szam == 3)
                {
                    Console.WriteLine("Válaszott menü:\n{0}", m3);
                }
                else if (szam == 4)
                {
                    Console.WriteLine("Válaszott menü:\n{0}", m4);
                }
                else if (szam == 5)
                {
                    Console.WriteLine("Kilépéshez nyomj entert!");
                }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Menusor megold = new Menusor();
            megold.menuk();
            Console.ReadKey();
        }
    }
}
