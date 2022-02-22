using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hianyzasok
{
    class Program
    {
        static void Main(string[] args)
        {
            string figy = "Nulla megrovás", //figyelmeztetes dek
                   jegy = "", //jegy dek
                    szd = "Nem megadott"; //születési dátum
            int ig = 0; //igazolatlan órák szána
            string[] jegyek = new string[] {"Rossz (2)", "Változó (3)", "Jó (4)", "Példás (5)"}; //ertekelés
            string[] figyel = new string[] {"Figyelmeztetés","Osztályfőnöki intő","Igazgatói megrovás","Felfüggesztés"}; //intők
            Console.WriteLine("kérlek add meg hány nap igazolatlannal rendelkezel!");
            ig = int.Parse(Console.ReadLine()); //igazolatlan bekérés

            if (ig >= 3)
            {
                jegy = jegyek[1];
                if (ig >= 10)
                {
                    figy = figyel[0];
                    Console.WriteLine("Kérlek add meg a születési dátumodat!");
                    szd = Console.ReadLine();
                    jegy = jegyek[0];
                    if (ig >= 50)
                    {
                        figy = figyel[3];
                        jegy = "Értékelhetetlen/Felfüggesztve";
                    }
                    else if (ig == 30)
                    {
                        figy = figyel[2];
                    }
                    else if (ig == 20)
                    {
                        figy = figyel[1];
                    }
                }

            }
            else if (ig == 1 || ig == 2)
            {
                jegy = jegyek[2];
            }
            else if (ig == 0)
            {
                jegy = jegyek[3];
            }

            Console.WriteLine("Igazolatlan hiányzások száma: {0}\nSzületési dátum: {1}\nMagatartási érdemjegyed: {2}\n{3}t kaptál!",ig,szd,jegy,figy);
            Console.ReadKey();
        }
    }
}
