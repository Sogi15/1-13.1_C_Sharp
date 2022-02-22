using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testtomeg_idx
{
    class Program
    {
        static void Main(string[] args)
        {
            //valtozok megadasa
            double suly = 0,
                   magassag = 0,
                   tti = 0;
            string msg = "";
            Console.WriteLine("Add meg a súlyod!:");
            suly = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a magasságod!:");
            magassag = int.Parse(Console.ReadLine());
            tti = suly / (magassag * magassag) * 10000;
            if (tti < 16)
            {
                msg = "Súlyos soványság";
            }
            else if (tti > 16 && tti < 16.99)
            {
                msg = "Mérsékelt soványság";
            }
            else if (tti > 17 && tti < 18.49)
            {
                msg = "Enyhe soványság";
            }
            else if (tti > 18.5 && tti < 24.99)
            {
                msg = "Normális testsúly";
            }
            else if (tti > 25 && tti < 29.99)
            {
                msg = "Túlsúlyos";
            }
            else if (tti > 30 && tti < 34.99)
            {
                msg = "I. fokú elhízás";
            }
            else if (tti > 35 && tti < 39.99)
            {
                msg = "II. fokú elhízás";
            }
            else
            {
                msg = "III. fokú (súlyos) elhízás";
            }

            Console.WriteLine("Súly: {0} kg\nMagasság: {1} cm \nTesttömegindex: {2} m2\nTestsúlyosztályozás: {3}",suly,magassag,tti,msg);
            Console.ReadKey();
        }
    }
}
