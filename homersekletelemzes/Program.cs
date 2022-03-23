using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homersekletelemzes
{
    class Homerseklet {
        private string[] evszaktomb = new string[] {"Tél","Tavasz","Nyár","Ősz"};
        private int nap, hoidx, beho,minho,maxho,napminho,napmaxho;
        private int[] hoho = new int[] { };
        private int[] napho = new int[] { };
        private int[] evho = new int[] { };
        private string evszak, honap;
        private Random rdm = new Random();

        public void behonap() {
            Console.WriteLine("Írd be kérlek hanyadik hónap! (1-12)");
            beho = int.Parse(Console.ReadLine());
            if (beho > 12 || beho < 1)
            {
                Console.WriteLine("Kérlek helyesen írd be a hónap számát [1-12] !!");
            }
            switch (beho)
            {
                case 1: honap = "Január";evszak = evszaktomb[0]; hoidx = 31; break;
                case 2: honap = "Február"; evszak = evszaktomb[0]; hoidx = 28; break;
                case 3: honap = "Március"; evszak = evszaktomb[1]; hoidx = 31; break;
                case 4: honap = "Április"; evszak = evszaktomb[1]; hoidx = 30; break;
                case 5: honap = "Május"; evszak = evszaktomb[1]; hoidx = 31; break;
                case 6: honap = "Június"; evszak = evszaktomb[2]; hoidx = 30; break;
                case 7: honap = "Július"; evszak = evszaktomb[2]; hoidx = 31; break;
                case 8: honap = "Augusztus"; evszak = evszaktomb[2]; hoidx = 31; break;
                case 9: honap = "Szeptember"; evszak = evszaktomb[3]; hoidx = 30; break;
                case 10: honap = "Október"; evszak = evszaktomb[3]; hoidx = 31; break;
                case 11: honap = "November"; evszak = evszaktomb[3]; hoidx = 30; break;
                case 12: honap = "December"; evszak = evszaktomb[0]; hoidx = 31; break;
            }
            Console.WriteLine("Kérlek add meg a dátumot! (1-31)");
            nap = int.Parse(Console.ReadLine());
        }
        public void honapho()
        {
            if (hoidx == 28 || nap <= 28 || nap >= 1)
            {
                for (int i = 0; i < napho.Length; i++)
                {
                    napho[i] = rdm.Next(-10,10);
                }
            }
            else { Console.WriteLine("Február csak 28 napból áll!"); }
        }
        public void kiiras()
        {
            Console.WriteLine("Válaszott hónap: {0}\nVálaszott évszak: {1}\nVálasztott dátum: {2}\nHőmérséklet:\nMin: {3} | Max: {4}", honap, evszak, nap,napminho,napmaxho);
        }
        public Homerseklet() { }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Homerseklet megoldas = new Homerseklet();
            megoldas.behonap();
            megoldas.honapho();
            megoldas.kiiras();
            Console.ReadKey();

        }
    }
}
