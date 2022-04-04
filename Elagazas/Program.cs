using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elagazas
{
    class Elagaz { 
    public Elagaz() { }
        private List<int> lista,paros;
        private Random rdm = new Random();
        private int[] tomb = new int[] { };
        public void megold()
        {
            lista = new List<int>();
            paros = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                lista.Add(rdm.Next(0, 100));
            }
            Console.WriteLine("Lista elemei:");
            foreach (var szam in lista)
            {
                Console.WriteLine("Elem: {0}", szam);
                if (szam % 2 == 0)
                {
                    paros.Add(szam);
                }
            }
            Console.WriteLine("Páros számok a listában:");
            foreach (var kiir in paros)
            {
                Console.WriteLine("Elem: {0}", kiir);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Elagaz megoldas = new Elagaz();
            megoldas.megold();
            Console.ReadKey();
        }
    }
}
