using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_dolgozat3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rdm = new Random();
            int N = rdm.Next(5, 10);
            double paros = 0,
                paratlan = 0;
            int[] szamtomb = new int[N];
            Console.WriteLine("Írj be {0} db számot!",N);
            for (int i = 0; i < szamtomb.Length; i++)
            {
                szamtomb[i] = int.Parse(Console.ReadLine());
                if (szamtomb[i] % 2 == 0)
                {
                    paros++;
                }
                else if (szamtomb[i] % 2 == 1)
                {
                    paratlan++;
                }
            }
            Console.WriteLine("Páros számok: {0}\nPáratlan számok: {1}",paros,paratlan);
            Console.ReadKey();


        }
    }
}
