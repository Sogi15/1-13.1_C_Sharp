using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorozatok
{
    public class Sorozat
    {
        private double[] sorozatelemek = new double[4];
        private double a;
        private double b;
        private double c;
        private double d;
        private bool szamtani,mertani;
        public Sorozat(double a, double b, double c, double d)
        {
            sorozatelemek[0] = a;
            sorozatelemek[1] = b;
            sorozatelemek[2] = c;
            sorozatelemek[3] = d;
        }
        public bool megold() {
            this.a = sorozatelemek[0];
            this.b = sorozatelemek[1];
            this.c = sorozatelemek[2];
            this.d = sorozatelemek[3];
            Console.WriteLine("Beírt számok:");
            for (int i = 0; i < sorozatelemek.Length; i++)
            {
                Console.WriteLine(sorozatelemek[i]);
            }
            if (this.d - this.c == this.c - this.b & this.c - this.b == this.b - this.a)
            {
                Console.WriteLine("Ez egy számtani sorozat!");
                szamtani = true;
                mertani = false;
            }
            else
            {
                if (this.d / this.c == this.c / this.b & this.c / this.b == this.b / this.a)
                {
                    Console.WriteLine("Ez egy mértani sorozat!");
                    szamtani = false;
                    mertani = true;
                }
                else { Console.WriteLine("A beírt számok egyik sorozatnak sem felelnek meg"); szamtani = false; mertani = false; }
            }
            return szamtani;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írj be 4db számot");
            Sorozat megoldas = new Sorozat(Convert.ToDouble(Console.ReadLine()),
            Convert.ToDouble(Console.ReadLine()),
            Convert.ToDouble(Console.ReadLine()),
            Convert.ToDouble(Console.ReadLine()));
            megoldas.megold();
            Console.ReadKey();
        }
    }
}
