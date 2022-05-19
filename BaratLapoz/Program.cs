using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaratLapoz
{
    class BLapoz
    {
        private string nev;
        private DateTime szuletes;
        private char nem;
        private int buli, tovabb = 0;
        private string sor; // Egy sor beolvasása
        private string[] mezo; // Sor szétbontása



        public BLapoz() { }

        public BLapoz(string nev, DateTime szuletes, char nem, int buli)
        {
            this.nev = nev;
            this.szuletes = szuletes;
            this.nem = nem;
            this.buli = buli;
        }

        public void printBarat()
        {
            Console.WriteLine("{0,-20} {1,-10} {2,1} {3}", nev, szuletes.ToShortDateString(), nem, buli);
        }
        private List<BLapoz> baratLista = new List<BLapoz>(); // Ebben tároljuk a barát dokumentumot + lista létrehozás
        public void bekeres()
        {
            // Féjlnév beolvasása
            // Beolvasás fájlból
            using (StreamReader sr = new StreamReader("baratlapoz.txt", Encoding.Default))
                while (sr.EndOfStream == false)
                {
                    sor = sr.ReadLine();
                    if (sor.Trim().Length == 0) continue; // Ha üres a sor, akkor léptetünk

                    mezo = sor.Split('|'); // Szétbontás

                    // Hozzáadás a listához
                    baratLista.Add(new BLapoz(
                        mezo[0],
                        DateTime.Parse(mezo[1]),
                        char.Parse(mezo[2]),
                        int.Parse(mezo[3])));

                    var valtozo = mezo[0] + " " + mezo[1] + " " + mezo[2] + " " + mezo[3];
                        for (int i = 0; i < 1; i++)
                        {
                            if (int.Parse(mezo[3]) <= 20)
                            {
                                Console.WriteLine(valtozo);
                            }
                        }
                        for (int i = 0; i < 1; i++)
                        {
                            if (int.Parse(mezo[3]) > 20 && int.Parse(mezo[3]) <= 40)
                            {
                                Console.WriteLine(valtozo);
                            }
                        }
                }
        }
        public void Kiir()
        {

            //foreach (BLapoz key in baratLista)
            //{
            //        key.printBarat();
            //}
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BLapoz bl = new BLapoz();
            bl.bekeres();
            bl.Kiir();
            Console.ReadKey();
        }
    }
}
