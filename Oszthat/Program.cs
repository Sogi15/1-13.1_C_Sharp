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
        public Osztogep(int beszam) { this.beszam = beszam; }
        public int setSzam()
        {
            do
            {
                try
                {
                    Console.WriteLine("Írj be egy számot!");
                    this.beszam = int.Parse(Console.ReadLine());
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
        public string getSzam()
        {
            string ert = string.Empty;
            if (this.beszam % 3 == 0) { ert = "Három"; if (this.beszam % 5 == 0 && this.beszam % 3 == 0) { ert = "Három | Öt"; } }
            else if (this.beszam % 5 == 0) { ert = "Öt"; }
            else {ert = Convert.ToString(beszam); }
            Console.WriteLine(ert);
            return ert;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Osztogep megold = new Osztogep(0);
            megold.setSzam();
            megold.getSzam();
            Console.ReadKey();
        }
    }
}
