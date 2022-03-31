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
            Console.WriteLine("1| {0}\n2| {1}\n3| {2}\n4| {3}\n5| Kilépés",m1,m2,m3,m4);
            int szam = Console.ReadKey().KeyChar;
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
