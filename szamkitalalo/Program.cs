using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamkitalalo
{
    class Program
    {
        static void Main(string[] args)
        {       
            Console.WriteLine("Válasz Játékmódot");
            Console.WriteLine("1. PC dönt");
            Console.WriteLine("2. Player dönt");
            int rk = Console.ReadKey(true).KeyChar;
            if (rk == '1')
            {
                Console.WriteLine("AI kezdi a játékot");
            }
            else if (rk == '2')
            {
                Console.WriteLine("Játékos kezd!");
            }
            else
            {
                Console.WriteLine("Kérlek 1/2 számot add meg!");
            }
            
                

            Console.ReadKey();
        }
    }
}
