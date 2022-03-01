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
        protected string hang;

        public Allat(string nev, string fajta, string szin)
        {
            this.nev = nev;
            this.fajta = fajta;
            this.szin = szin;
        }

        public Allat()
        {
            this.nev = "anonim";
            this.fajta = "ismeretlen";
            this.szin = "fekete";
            this.kor = 0;
        }

        public string hangotAd(){return this.hang;}
        public string getnev(){return this.nev;}
        public string getfajta(){return this.fajta;}
        public string getszin(){return this.szin;}
        public int getkor(){return this.kor;}
        public void setHang(string h) {if (h != ""){this.hang = h;}}
        public void setKor(int p){if (p > 0 && p < 50){this.kor = p;}}
        public void setNev(string n){if (n != ""){this.nev = n;}}
        public void setFajta(string f){if (f != ""){this.fajta = f;}}
        public void setSzin(string s){if (s != ""){this.szin = s;}}}
    class Kutya : Allat
    {
        //osztályváltozó
        private string gazda;

        public Kutya(string nev, string fajta, string szin) : base(nev,fajta,szin)
        {
            this.gazda = "ismeretlen";
            this.hang = "Vauuu Vauu";
        }
        public void setGazda(string p) {this.gazda = p;}
        public string getGazda() { return this.gazda;}

    }
    class Macska : Allat
        {
            public Macska(string nev, string fajta, string szin) : base(nev,fajta,szin)
        {
            this.hang = "Miauuu";
        }
        }
    class Program
    {
        static void Main(string[] args)
        {
            // példányosítunk objektumokat
            Allat allat1 = new Allat("Bodri","Puli","Fekete");
            allat1.setKor(2);
            Console.WriteLine("Az állat neve: {0}\nAz állat fajtája: {1}\nAz állat színe: {2}\nAz állat kora: {3} éves\n", allat1.getnev(),allat1.getfajta(),allat1.getszin(),allat1.getkor());
            Allat allat2 = new Allat("Bolhás", "Komondor", "Fehér");
            allat2.setKor(10);
            Console.WriteLine("Az állat neve: {0}\nAz állat fajtája: {1}\nAz állat színe: {2}\nAz állat kora: {3} éves\n", allat2.getnev(),allat2.getfajta(),allat2.getszin(),allat2.getkor());
            Allat allat3 = new Allat();
            Console.WriteLine("Az állat neve: {0}\nAz állat fajtája: {1}\nAz állat színe: {2}\nAz állat kora: {3} éves\n", allat3.getnev(),allat3.getfajta(),allat3.getszin(),allat3.getkor());
            allat3.setKor(23);
            allat3.setNev("CsicskaLángos");
            allat3.setFajta("Korcs Terrier");
            allat3.setSzin("Barna");
            allat3.setHang("Vauu Vauu te Kurva");
            Console.WriteLine("Az állat neve: {0}\nAz állat fajtája: {1}\nAz állat színe: {2}\nAz állat kora: {3} éves\nAz állat hangja: {4}", allat3.getnev(),allat3.getfajta(),allat3.getszin(),allat3.getkor(),allat3.hangotAd());
            Console.WriteLine("\n================================= Származtatott =====================================\n");
            Kutya kutya1 = new Kutya("Bogár","Puli","Fekete");
            kutya1.setKor(5);
            kutya1.setHang("Dugulsz Kutya");
            kutya1.setGazda("Lakatos Huján Mígel");
            Console.WriteLine("Az kutya neve: {0}\nAz kutya fajtája: {1}\nAz kutya színe: {2}\nAz kutya kora: {3} éves\nAz kutya hangja: {4}\nAz kutya gazdája: {5}", kutya1.getnev(),kutya1.getfajta(),kutya1.getszin(),kutya1.getkor(),kutya1.hangotAd(),kutya1.getGazda());
            Macska macska1 = new Macska("Paul Fincs Jr.","Siami","Sárga,szürke cirmos");
            macska1.setKor(2);
            macska1.setHang("Agyá enni te bánat");
            Console.WriteLine("\n\nAz macska neve: {0}\nAz macska fajtája: {1}\nAz macska színe: {2}\nAz macska kora: {3} éves\nAz macska hangja: {4}", macska1.getnev(),macska1.getfajta(),macska1.getszin(),macska1.getkor(),macska1.hangotAd());
            Console.ReadKey();
        }
    }
}
