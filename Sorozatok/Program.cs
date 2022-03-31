using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorozatok
{
    class Sorozat
    {
        private double[] sorozatelemek = new double[4];

        public void bekeres()
        {
            Console.WriteLine("Írj be 4db számot");
            sorozatelemek[0] = Convert.ToDouble(Console.ReadLine());
            sorozatelemek[1] = Convert.ToDouble(Console.ReadLine());
            sorozatelemek[2] = Convert.ToDouble(Console.ReadLine());
            sorozatelemek[3] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Beírt számok:");
            double a = sorozatelemek[0];
            double b = sorozatelemek[1];
            double c = sorozatelemek[2];
           double d = sorozatelemek[3];
            for (int i = 0; i < sorozatelemek.Length; i++)
            {
                Console.WriteLine(sorozatelemek[i]);
            }
            if (d-c==c-b&c-b==b-a)
            {
                Console.WriteLine("Ez egy számtani sorozat!");
            }
            else
            {
                if (d / c == c / b & c / b == b / a)
                {
                    Console.WriteLine("Ez egy mértani sorozat!");
                }
                else { Console.WriteLine("A beírt számok egyik sorozatnak sem felelnek meg"); }
            }
        }
        public Sorozat() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sorozat megoldas = new Sorozat();
            megoldas.bekeres();
            Console.ReadKey();
        }
    }
}
