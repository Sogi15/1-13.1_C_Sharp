using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minmax
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1000;
            int max = -1;
            int minIdx = 0;
            int maxIdx = 0;
            Random rdm = new Random();
            int[] array = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rdm.Next(0,1000);
            }
            for (int i = 0; i < array.Length; i++)
            {             
                if (array[i] < min)
                {
                    min = array[i];
                    minIdx = i;
                }
                if (array[i] > max)
                {
                    max = array[i];
                    maxIdx = i;
                }
            }
            Console.WriteLine("A minimum szám {0}, az indexe {1}", min, minIdx);
            Console.WriteLine("A maximum szám {0}, az indexe {1}", max, maxIdx);
            Console.ReadKey();
        }
    }
}
