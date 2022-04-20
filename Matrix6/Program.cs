using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix6
{
    class Matrixfour
    {
        private int sor, oszlop, sidx, oidx, szam;
        private string beolvas = "";
        private char valasz;
        private bool igen = true;
        private int[,] matrix;
        private bool[,] tf;
        public void bevizs()
        {
            Console.WriteLine("Írd be a sorok számát!");
            sor = int.Parse(Console.ReadLine());
            Console.WriteLine("Írd be az oszlopok számát!");
            oszlop = int.Parse(Console.ReadLine());
            matrix = new int[sor, oszlop];
            tf = new bool[sor, oszlop];
            do
            {
                Console.WriteLine("írj be 3db egyjegyű számot vesszővel elválasztva! (sor,oszlop,érték)");
                beolvas = Console.ReadLine();
                if (beolvas == "")
                {
                    Console.WriteLine("Kérlek írd be a válaszokat! (sor,oszlop,érték)");
                    beolvas = Console.ReadLine();
                }
                else
                {
                    beolvas = String.Concat(beolvas.Where(c => !Char.IsWhiteSpace(c)));
                    sidx = Convert.ToInt32(beolvas[0].ToString()) - 1;
                    oidx = Convert.ToInt32(beolvas[2].ToString()) - 1;
                    szam = Convert.ToInt32(beolvas[4].ToString());
                    if (sidx > sor || oidx > oszlop)
                    {
                        Console.WriteLine("Kérlek az indexekre figyelj oda, hiszen a megadott index a határokon kívülre esett!");
                    }
                    else
                    {
                        if (tf[sidx, oidx] == true)
                        {
                            Console.WriteLine("Már beírtál erre az indexre egy karaktert!");
                        }
                        else { matrix[sidx, oidx] = szam; tf[sidx, oidx] = true; }

                    }

                }
                Console.WriteLine("Szeretnéd folytatni a beolvasást? i/n");
                valasz = Console.ReadKey().KeyChar;
                Console.Write("\n");
                if (valasz == 'i')
                {
                    igen = true;
                }
                else
                {
                    szam = 0;
                    for (int id = 0; id < matrix.GetLength(0); id++)
                    {
                        for (int xd = 0; xd < matrix.GetLength(1); xd++)
                        {
                            if (tf[id, xd] == true)
                            {
                                break;
                            }
                            else { szam++; tf[id, xd] = true; }
                        }
                    }
                    igen = false;
                }
            } while (igen == true);
        }
        public void kiir()
        {
            if (igen == false)
            {
                Console.WriteLine("Beírt számok a mátrixba:");
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int k = 0; k < matrix.GetLength(1); k++)
                    {
                        Console.Write(matrix[i, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("A mátrixban nem kitöltött számok száma: {0}db", szam);
            }
        }
        public Matrixfour() { }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Matrixfour megold = new Matrixfour();
            megold.bevizs();
            megold.kiir();
            Console.ReadKey();
        }
    }
}
