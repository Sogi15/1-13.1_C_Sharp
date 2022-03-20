using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cimletezes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Változók
            int[,] penz = new int[,] { { 20000, 0 }, { 10000, 0 }, { 5000, 0 }, { 2000, 0 }, { 1000, 0 }, { 500, 0 }, { 200, 0 }, { 100, 0 }, { 50, 0 }, { 20, 0 }, { 10, 0 }, { 5, 0 } };
            int ertek;

            Console.WriteLine("Írd be az összeget!");
            ertek = int.Parse(Console.ReadLine());

            for (int i = 0; i < penz.GetLength(0); i++)
            {
                if (ertek >= penz[i, 0])
                {
                    if (ertek != 0)
                    {
                        penz[i, 1] = ertek / penz[i, 0];
                        ertek = ertek % penz[i, 0];
                    }
                }

                Console.WriteLine("{0} forintosból, {1} db kell!", penz[i, 0], penz[i, 1]);
            }


            Console.ReadKey();
        }
    }
}