using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220328
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do {
                Console.WriteLine("Írj be egy számot!");
                num = int.Parse(Console.ReadLine());
                try
                {
                    num = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Karaktert írtál be szám helyett!");
                }
            } while (num);
            Console.ReadKey();
        }
    }
}
