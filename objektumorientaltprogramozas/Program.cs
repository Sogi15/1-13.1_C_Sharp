using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektumorientaltprogramozas
{
    class Allat
    {
        // Osztályváltozók (properties)
        private string nev;
        private string fajta;
        private string szin;
        private int kor;

        public Allat(string nev, string fajta, string szin)
        {
            this.nev = nev;
            this.fajta = fajta;
            this.szin = szin;
        }

        public string getnev()
        {
            return this.nev;
        }
        public string getfajta()
        {
            return this.fajta;
        }
        public string getszin()
        {
            return this.szin;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // példányosítunk objektumokat
            Allat allat1 = new Allat("Bodri","Puli","Fekete");
            Console.WriteLine("Az állat neve: {0}", allat1.getnev(),allat1.getfajta());
            Allat allat2 = new Allat("Bolhás", "Komondor", "Fehér");
            Console.WriteLine("Az állat neve: {0}", allat2.getnev());
            Console.ReadKey();
        }
    }
}
