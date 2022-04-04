using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listak
{
    class Lista
    {
        private Random rdm = new Random();
        private int[] szamok = new int[10];
        public Lista() { }
        public void megold()
        {
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rdm.Next(10, 99);
            }
            foreach (var szam in szamok)
            {
                Console.WriteLine(szam);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Lista megoldas = new Lista();
            megoldas.megold();
            Console.ReadKey();
        }
    }
}
