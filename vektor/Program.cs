using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektor
{
    class Vektor
    {
        // Osztályváltozók
        private int elemekszama,
            ertek,
            atlagertek,
            min,
            max,
            minimumIndex,
            maximumIndex;
        private int[] vektorhossz;

        // Random szám generálás

        Random rand = new Random();

        public Vektor() { }

        public void Feltoltes()
        {
            Console.WriteLine("Írja be a vektor hosszát:");
            elemekszama = int.Parse(Console.ReadLine());
            vektorhossz = new int[elemekszama];
            for (int i = 0; i < elemekszama; i++)
            {
                vektorhossz[i] = rand.Next(0, 100);
            }
        }

        public void setOsszeg()
        {
            int osszeg = 0;
            for (int i = 0; i < vektorhossz.Length; i++)
            {
                osszeg = osszeg + vektorhossz[i];
            }
            this.ertek = osszeg;
        }

        public int getOsszeg()
        {
            Console.WriteLine("Az összeg: {0}", this.ertek);
            return this.ertek;
        }

        public void setFindAtlag()
        {
            int atlag;
            atlag = this.ertek / vektorhossz.Length;
            this.atlagertek = atlag;
        }

        public double getFindAtlag()
        {
            Console.WriteLine("Az átlag: {0}", this.atlagertek);
            return this.atlagertek;
        }

        public void setMinimum()
        {
            int minimum,
                minindex = 0;
            minimum = vektorhossz.Min();
            this.min = minimum;
            for (int i = 0; i < vektorhossz.Length; i++)
            {
                if (vektorhossz[i] == minimum)
                {
                    minindex = i;
                }
            }
            this.minimumIndex = minindex;
        }

        public int getMinimum()
        {
            Console.WriteLine("A legkisebb elem: {0}, helye: {1}", this.min, this.minimumIndex);
            return this.min;
        }

        public void setMaximum()
        {
            int maximum,
                maxindex = 0;
            maximum = vektorhossz.Max();
            this.max = maximum;
            for (int i = 0; i < vektorhossz.Length; i++)
            {
                if (vektorhossz[i] == maximum)
                {
                    maxindex = i;
                }
            }
            this.maximumIndex = maxindex;
        }

        public int getMaximum()
        {
            Console.WriteLine("A legnagyobb elem: {0}, helye: {1}", this.max, this.maximumIndex);
            return this.max;
        }

        class Program
        {
            static void Main(string[] args)
            {
                Vektor a = new Vektor();
                a.Feltoltes();
                a.setOsszeg();
                a.getOsszeg();
                a.setFindAtlag();
                a.getFindAtlag();
                a.setMinimum();
                a.getMinimum();
                a.setMaximum();
                a.getMaximum();
                Console.ReadKey();
            }
        }
    }
}