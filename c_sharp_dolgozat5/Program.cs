using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_dolgozat5
{
    class Program
    {
        static void Main(string[] args)
        {
            int epont = 0,
                mpont = 0;
            Console.WriteLine("Add meg az intervallum első értékét!");
            epont = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg az intervallum második értékét!");
            mpont = int.Parse(Console.ReadLine());
            for (int i = epont; i <= mpont; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine("5-el osztható számok: {0}",i);
                }    
            }
            Console.ReadKey();
            
            
        }
    }
}
