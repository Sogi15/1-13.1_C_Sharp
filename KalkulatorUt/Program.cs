using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorUt
{
    public class Calc
    {
        private int szam1 = 0, szam2 = 0;
        private char muvjel;
        private int eredmeny = 0;
        private string uzenet = "A múvelet eredménye: ";

        public Calc(int szam1, int szam2, char muvjel)
        {
            this.szam1 = szam1;
            this.szam2 = szam2;
            this.muvjel = muvjel;
        }
        public float Megoldas()
        {
                switch (this.muvjel)
                {
                    case '+':
                        this.eredmeny = this.szam1 + this.szam2;
                        break;
                    case '-':
                        this.eredmeny = this.szam1 - this.szam2;
                        break;
                    case '/':
                   try {
                        this.eredmeny = this.szam1 / this.szam2;
                    }
                    catch (DivideByZeroException e)
                    {
                        Console.WriteLine(e.Message);
                        return this.eredmeny = -0;
                    }
                        break;
                    case '*':
                        this.eredmeny = this.szam1 * this.szam2;
                        break;
                    default:
                        this.uzenet = "Hibás műveleti jel";
                        break;
                }
                Console.WriteLine(this.uzenet + this.eredmeny);
            return this.eredmeny;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írj be egymás után 2 számot majd egy műveleti jelet!");
            Calc megold = new Calc(int.Parse(Console.ReadLine()),
            int.Parse(Console.ReadLine()),
            Convert.ToChar(Console.Read()));
            megold.Megoldas();
            Console.ReadKey();
        }
    }
}
