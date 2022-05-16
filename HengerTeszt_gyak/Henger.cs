using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HengerTeszt_gyak
{
    class Henger
    {
        public double magassag { get; set; }
        public double sugar { get; set; }
        public Henger(double magassag, double sugar)
        {
            this.magassag = magassag;
            this.sugar = sugar;
        }

        public double setSugar()
        {
        Convert.ToDouble(Console.ReadLine());
            return this.sugar;
        }
        public double setMagas()
        {
            Convert.ToDouble(Console.ReadLine());
            return this.magassag;
        }
        public double getTerfogat()
        {
            return Math.PI * Math.Pow(this.sugar, 2) * this.magassag;
        }
        public double getFelszin()
        {
            return 2 * Math.PI * this.sugar * (this.sugar + this.magassag);
            
        }
        public double getKerulet()
        {
            return 2 * Math.PI * this.sugar;
        }
        public double getTerulet()
        {
            return Math.PI * Math.Pow(this.sugar, 2);
        }
    }
}
