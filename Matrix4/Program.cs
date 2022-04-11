using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sor, oszlop;
            string beolvas = string.Empty;
            Console.WriteLine("Írd be a sorok számát!");
            sor = int.Parse(Console.ReadLine());
            Console.WriteLine("Írd be az oszlopok számát!");
            oszlop = int.Parse(Console.ReadLine());
            int[,] matrix = new int[sor, oszlop];
            Console.WriteLine("írj be 3 egyjegyű számot vesszővel elválasztva!");
            beolvas = Console.ReadLine();
            beolvas = String.Concat(beolvas.Where(c => !Char.IsWhiteSpace(c)));
            // beolvas[0,2,4,]
            if (beolvas[1] == ',' && beolvas[3] == ',' && beolvas[5] == ',')
            {
            }
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int k = 0; k < matrix.GetLength(1); k++)
            //    {
            //        matrix[]
            //    }
            //}

            Console.ReadKey();
        }
    }
}
