using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oszthat
{
    public class Osztogep
    {
        private int beszam = 0;
        private bool helyes = false; //ha int-et írunk be akkor false
        public Osztogep() {}
        public int setSzam()
        {
            do
            {
                try
                {
                    Console.WriteLine("Írj be egy számot!");
                    beszam = int.Parse(Console.ReadLine());
                    helyes = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    helyes = true; //Ha karaktert vagy bármi mást írunk be akkor false és újra lefut
                }
            } while(helyes);
                return this.beszam;
        }
        public void getSzam()
        {
            string ert = string.Empty;
            if (beszam % 3 == 0)
            { ert = "Három"; }
            if (beszam % 5 == 0) { ert = "Öt"; }
            else {ert = Convert.ToString(beszam); }
            Console.WriteLine(ert);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Osztogep megold = new Osztogep();
            megold.setSzam();
            megold.getSzam();
            Console.ReadKey();
        }
    }
}
