using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorozatok
{
    class Sorozat
    {
        private int[] sorozatelemek = new int[4];

        public void bekeres()
        {
            Console.WriteLine("Írj be 4db számot");
            sorozatelemek[0] = int.Parse(Console.ReadLine());
            sorozatelemek[1] = int.Parse(Console.ReadLine());
            sorozatelemek[2] = int.Parse(Console.ReadLine());
            sorozatelemek[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Beírt számok:");
            for (int i = 0; i < sorozatelemek.Length; i++)
            {
                Console.WriteLine(sorozatelemek[i]);
            }
        }
        public void szamtani()
        {
            int a1, a2, a3;
            a1 = sorozatelemek[0] - sorozatelemek[1];
            a2 = sorozatelemek[1] - sorozatelemek[2];
            a3 = sorozatelemek[2] - sorozatelemek[3];
            if (a1 == a2 && a1 == a3)
            {
                Console.WriteLine("Ez egy számtani sorozat!\nDifferencia: {0}", a1);

            }
            else { Console.WriteLine("Ez nem egy számtani sorozat!"); }
        }
        public Sorozat() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sorozat megoldas = new Sorozat();
            megoldas.bekeres();
            megoldas.szamtani();
            Console.ReadKey();
        }
    }
}
