using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxUt
{
    public class MM
    {
        private int hossz = 0, minimum, maximum;
        private int[] szamsor, tesztszamok;
        private bool ffx = true;
        private Random rdm = new Random();
        public MM(int hossz, bool ffx, int[] tesztszamok)
        {
            this.hossz = hossz;
            this.ffx = ffx;
            this.tesztszamok = tesztszamok;
        }
        public void feltolt_rdm()
        {
            if (this.ffx == true)
            {
                szamsor = new int[this.hossz];
                for (int i = 0; i < szamsor.Length; i++)
                {
                    szamsor[i] = rdm.Next(0, 16);
                }
            }
        }
        public void feltolt_sajat()
        {
            if (this.ffx == false)
            {
                szamsor = new int[this.hossz];
                for (int y = 0; y < szamsor.Length; y++)
                {
                    szamsor[y] = tesztszamok[y];
                }
            }
        }
        public int getMin()
        {
            minimum = szamsor.Min();
            Console.WriteLine("A minimum szám: {0}", minimum);
            return minimum;
        }
        public int getMax()
        {
            maximum = szamsor.Max();
            Console.WriteLine("A maximum szám: {0}", maximum);
            return maximum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a számsor hosszúságát!");
            int hosszusag = int.Parse(Console.ReadLine());
            int[] tesztszamok = new int[hosszusag];
            bool bb = true;
            Console.WriteLine("Random generáljon számokat? I/N");
            char valasz = Console.ReadKey(true).KeyChar;
            if (valasz == 'i')
            {
                bb = true;
            }
            else if (valasz == 'n')
            {
                bb = false;
                for (int i = 0; i < tesztszamok.Length; i++)
                {
                    Console.WriteLine("{0}. elem megadása", i + 1);
                    tesztszamok[i] = int.Parse(Console.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("Mivel nem válaszoltál I/N betükkel ezért random generáltunk számokat!");
            }
            MM megold = new MM(hosszusag, bb, tesztszamok);
            megold.feltolt_rdm();
            megold.feltolt_sajat();
            megold.getMin();
            megold.getMax();
            Console.ReadKey();
        }
    }
}
