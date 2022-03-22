using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homersekletelemzes
{
    class Homerseklet {
        private string honap;
        private string[] evszak = new string[] {"Tél","Tavasz","Nyár","Ősz"};
        private int nap;

        public void behonap() {
            Console.WriteLine("Írd be kérlek hanyadik vagy melyik hónap!");
            honap = Console.ReadLine();
            if (honap == "01" || honap == "1" || honap == "január" || honap == "jan")
            {;
                Console.WriteLine("Válaszott hónap: Január\nVálaszott évszak: {0}");}
            else { Console.WriteLine("Kérlek helyesen írd be a hónap nevét!\nPld: [01/1/január/jan] !!"); }

        }
        public Homerseklet() { }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Homerseklet megoldas = new Homerseklet();
            megoldas.behonap();
            Console.ReadKey();

        }
    }
}
