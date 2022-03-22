using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homersekletelemzes
{
    class Homerseklet {
        private string datum;
        private int[] ho;
        private string evszak;
        private string honap;
        private string[] evszakok = new string[] { "Tél", "Tavasz", "Nyár", "Ősz" };
        private string[] honapok = new string[] { "Január", "Február", "Március", "Április", "Május", "Június", "Július", "Augusztus", "Szeptember", "Október", "November", "December" };
        private int[] hnapok = new int[] { 28, 30, 31 };
        private Random rdm = new Random();
        public Homerseklet(string datum) { this.datum = datum; }
        public Homerseklet() {}
        public void bekeres() {
            Console.WriteLine("Kérlek válassz egy évszakot!!\n1 = Tél\n 2 = Tavasz\n 3 = Nyár\n 4 = Ősz\n");
            char be = Console.ReadKey().KeyChar;
            if (be == '1') { Console.WriteLine("Tál"); }
            else if (be == '2') { Console.WriteLine("Tál"); }
            else if (be == '3') { Console.WriteLine("Tál"); }
            else if (be == '4') { Console.WriteLine("Tál"); }
        }
        public void date()
        {

            //switch (Console.ReadLine())
            //{
            //    case "januar": evszak = evszakok[0];honap = honapok[0];
            //        switch () { }
            //        break;
            //}
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Homerseklet megoldas = new Homerseklet();
            megoldas.bekeres();
            Console.ReadKey();

        }
    }
}
