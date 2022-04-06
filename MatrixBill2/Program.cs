using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixBill
{
    class Program
    {
        class Matrix
        {
            protected int sor, oszlop;
            protected int[,] matrix;
            public Matrix() { }
            public virtual void megold()
            {
                Console.WriteLine("Hány sor legyen a mátrix?");
                sor = int.Parse(Console.ReadLine());
                Console.WriteLine("Hány oszlop legyen a mátrix?");
                oszlop = int.Parse(Console.ReadLine());
                Console.WriteLine("Kérlek add meg az elemeket!");
                matrix = new int[sor, oszlop];
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write("Kérem a(z) {0} sor {1} oszlopa elemet: ", i + 1, j + 1);
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }
            }
            public void kiir()
            {
                Console.WriteLine("Mátrix elemeinek kiírása\n==========================");
                for (int x = 0; x < sor; x++)
                {
                    for (int d = 0; d < oszlop; d++)
                    {
                        Console.Write("{0} ", matrix[x, d]);
                    }
                    Console.WriteLine();
                }
            }
        }
        class Sorja : Matrix {
        public Sorja() { }
            public override void megold()
            {
                Console.WriteLine("Hány sor legyen a mátrix?");
                sor = int.Parse(Console.ReadLine());
                Console.WriteLine("Hány oszlop legyen a mátrix?");
                oszlop = int.Parse(Console.ReadLine());
                Console.WriteLine("Kérlek add meg az elemeket!");
                matrix = new int[sor, oszlop];
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write("Kérem a(z) {0} sor {1} oszlopa elemet: ", i + 1, j + 1);
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("======= Sor Elemei =======");
                    for (int k = 0; k < matrix.GetLength(1); k++)
                    {
                        Console.Write(matrix[i,k] + " ");
                    }
                    Console.WriteLine("\n==========================");
                }
            }
        }
        static void Main(string[] args)
        {
            Sorja megold1 = new Sorja();
            megold1.megold();
            megold1.kiir();
            Console.ReadKey();
        }
    }
}
