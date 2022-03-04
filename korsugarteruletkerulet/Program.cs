using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korsugarteruletkerulet
{
    class Kor
    {
        private int sugar;
        private double kerulet;
        private double terulet;
        public Kor(int sugar,double kerulet,double terulet) {
            this.sugar = sugar;
            this.kerulet = kerulet;
            this.terulet = terulet;
        }
        public Kor() { }
        public int getSugar() { return this.sugar; }
        public void setSugar() { int R = int.Parse(Console.ReadLine()); if (R != 0) { this.sugar = R; } }
        public double getKerulet() {
            this.kerulet = 2 * getSugar() * Math.PI;
            return this.kerulet; }
        public double getTerulet() {
            this.terulet = (getSugar() * getSugar())*Math.PI;
            return this.terulet; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Sugár bekérés:
            char valasztas;
            Console.WriteLine("Kérlek add meg a kör sugarát!");
            Kor R = new Kor();
            R.setSugar();
            Console.WriteLine("Területet vagy Kerületet számoljunk? (K/T)");
            valasztas = Console.ReadKey().KeyChar;
            R.getKerulet();
            R.getTerulet();
            if (valasztas == 'k')
            {
                Console.WriteLine("\nKerület: {0}", R.getKerulet());
            }
            else if (valasztas == 't')
            {
                Console.WriteLine("\nTerület: {0}", R.getTerulet());
            }
            else if (valasztas != 't' || valasztas != 'k')
            {
                Console.WriteLine("Kérlek T vagy K betükkel válaszolj!");
            }
            Console.ReadKey();
        }
    }
}
