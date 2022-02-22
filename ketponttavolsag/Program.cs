using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ketponttavolsag
{
    class Program
    {
        static void Main(string[] args)
        {
            int epont = 0,
                eepont = 0,
                mmpont = 0,
                mpont = 0;
            double tavolsag = 0;
            Console.WriteLine("Add meg az első pont szélességét");
            epont = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg az első pont hosszúságát");
            eepont = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg az másodk pont szélességét");
            mpont = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg az második pont hosszúságát");
            mmpont = int.Parse(Console.ReadLine());
            //tavolsagn = ((epont - eepont)*(epont - eepont))+((mpont - mmpont)*(mpont - mmpont));
            tavolsag = Math.Sqrt(Math.Pow(epont - eepont, 2)+Math.Pow(mpont-mmpont,2));
            Console.WriteLine("A két pont közötti távolság: {0}",tavolsag);
            Console.ReadKey();
        }
    }
}
