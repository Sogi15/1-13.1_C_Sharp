using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homersekletelemzes
{
    class Homerseklet {
        private string[] evszaktomb = new string[4] {"Tél","Tavasz","Nyár","Ősz"};
        private int nap, hoidx, beho,minho,maxho,napmax,napmin,i;
        private int[] homerseklet, homin, homax, evimin, evimax;
        private string evszak, honap;
        private double napi,havi,evi;
        private Random rdm = new Random();

        public void behonap() {
            Console.WriteLine("Írd be kérlek hanyadik hónap! (1-12)");
            beho = int.Parse(Console.ReadLine());
            if (beho > 12 || beho < 1)
            {
                Console.WriteLine("Kérlek helyesen írd be a hónap számát [1-12] !!");
            }
            else
            {
                switch (beho)
                {
                    case 1: honap = "Január"; evszak = evszaktomb[0]; hoidx = 31; break;
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
            homerseklet = new int[hoidx];
        }
        public void honapho()
        {
            if (evszak == "Tél")
            {
                for (i = 0; i < homerseklet.Length; i++)
                {
                    homerseklet[i] = rdm.Next(-20, 5);
                }
            }
            else if (evszak == "Tavasz")
            {
                for (i = 0; i < homerseklet.Length; i++)
                {
                    homerseklet[i] = rdm.Next(-1, 20);
                }
            }
            else if (evszak == "Nyár")
            {
                for (i = 0; i < homerseklet.Length; i++)
                {
                    homerseklet[i] = rdm.Next(10, 40);
                }
            }
            else if (evszak == "Ősz")
            {
                for (i = 0; i < homerseklet.Length; i++)
                {
                    homerseklet[i] = rdm.Next(0, 22);
                }
            }
            for (int x = 0; x < homerseklet.Length; x++)
            {
                if (homerseklet[x] < minho)
                {
                    minho = homerseklet[x];
                    napmin = minho;
                }
                else if (homerseklet[x] > maxho)
                {
                    maxho = homerseklet[x];
                    napmax = maxho;
                }
            }
            homax = new int[hoidx];
            homin = new int[hoidx];
            evimax = new int[12];
            evimin = new int[12];
            for (int o = 0; o < homerseklet.Length; o++)
            {
                for (i = 0; i < hoidx; i++)
                {
                    if(homerseklet[i] < minho)
                    {
                    }
                }
            }
            napi = (napmax + napmin) / 2;
            //havi = (homax + homin) / 2;
            //evi = (evimax + evimin) / 2;
        }
        public void kiiras()
        {
            if (nap != 0)
            {
                if (hoidx == 28 && nap <= 28 && nap >= 1)
                {
                    Console.WriteLine("Válaszott évszak: {0}", evszak);
                    Console.WriteLine("Válaszott hónap: {0}", honap);
                    Console.WriteLine("Válaszott nap: {0}\nHőmérséklet:\nMin: {1} | Max {2} | Átlag: {3}", nap,napmin,napmax,napi);
                }
                else if (hoidx == 30 && nap <= 30 && nap >= 1)
                {
                    Console.WriteLine("Válaszott évszak: {0}", evszak);
                    Console.WriteLine("Válaszott hónap: {0}", honap);
                    Console.WriteLine("Válaszott nap: {0}\nHőmérséklet:\nMin: {1} | Max {2} | Átlag: {3}", nap, napmin, napmax, napi);
                }
                else if (hoidx == 31 && nap <= 31 && nap >= 1)
                {
                    Console.WriteLine("Válaszott évszak: {0}", evszak);
                    Console.WriteLine("Válaszott hónap: {0}", honap);
                    Console.WriteLine("Válaszott nap: {0}\nHőmérséklet:\nMin: {1} | Max {2} | Átlag: {3}", nap, napmin, napmax, napi);
                }
                else { Console.WriteLine("{0} csak {1} napból áll!", honap,hoidx); }
            }
            else { Console.WriteLine("Nem létezik nullás dátum!"); }
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
