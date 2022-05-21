﻿using System;
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
            Console.WriteLine("{0,-20} {1,-10} {2,1} {3}", this.nev, this.szuletes.ToShortDateString(), this.nem, this.buli);
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
                }
        }
        public void Kiir()
        {
            var page1= baratLista.GetRange(0,20);
            var page2 = baratLista.GetRange(20,20);
            var page3 = baratLista.GetRange(40, 20);
            var page4 = baratLista.GetRange(60, 20);
            var page5 = baratLista.GetRange(80, 20);
            do
            {
                if (tovabb == 0)
                {
                    foreach (BLapoz key in page1)
                    {
                        key.printBarat();
                    }
                }
                else if (tovabb == 1)
                {
                    foreach (BLapoz key in page2)
                    {
                        key.printBarat();
                    }
                }
                else if (tovabb == 2)
                {
                    foreach (BLapoz key in page3)
                    {
                        key.printBarat();
                    }
                }
                else if (tovabb == 3)
                {
                    foreach (BLapoz key in page4)
                    {
                        key.printBarat();
                    }
                }
                else if (tovabb == 4)
                {
                    foreach (BLapoz key in page5)
                    {
                        key.printBarat();
                    }
                }
                var gomb = Console.ReadKey(true);
                if (gomb.Key == ConsoleKey.PageUp)
                {
                    Console.Clear();
                   tovabb = tovabb + 1;
                }
                else if (gomb.Key == ConsoleKey.Home)
                {
                    Console.Clear();
                    tovabb = 0;
                }
                else if (gomb.Key == ConsoleKey.End)
                {
                    Console.Clear();
                    tovabb = 4;
                }
                else if (gomb.Key == ConsoleKey.PageDown)
                {
                    Console.Clear();
                    tovabb = tovabb - 1;
                }
                else { Console.Clear(); continue; }
            } while (tovabb > -1 && tovabb < 5);
            if (tovabb < 0 || tovabb > 5)
            {
                Console.WriteLine("A könyvet bezártad a program kilép!");
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BLapoz bl = new BLapoz();
            bl.bekeres();
            bl.Kiir();
        }
    }
}
