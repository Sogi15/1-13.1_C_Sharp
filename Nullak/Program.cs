using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullak
{
    class Nulls
    {
        private Random rdm = new Random();
        private string sz1, sz2,sz3,sz4,sz5,sz6,sz7,sz8,sz9,sz10,ered;
        private int nulla = 0,nulle;
        private int[] szam = new int[10], nnn = new int[10];
        public Nulls() { }

        public void randoms() {for (int k = 0; k < szam.Length; k++){szam[k] = rdm.Next(0, 1000);}}
        public void lengts()
        {
            sz1 = Convert.ToString(szam[0]);
            sz2 = Convert.ToString(szam[1]);
            sz3 = Convert.ToString(szam[2]);
            sz4 = Convert.ToString(szam[3]);
            sz5 = Convert.ToString(szam[4]);
            sz6 = Convert.ToString(szam[5]);
            sz7 = Convert.ToString(szam[6]);
            sz8 = Convert.ToString(szam[7]);
            sz9 = Convert.ToString(szam[8]);
            sz10 = Convert.ToString(szam[9]);
            Console.WriteLine(sz1);
            Console.WriteLine(sz2);
            Console.WriteLine(sz3);
            Console.WriteLine(sz4);
            Console.WriteLine(sz5);
            Console.WriteLine(sz6);
            Console.WriteLine(sz7);
            Console.WriteLine(sz8);
            Console.WriteLine(sz9);
            Console.WriteLine(sz10);
            for (int i = 0; i < sz1.Length; i++)
            {
                if (sz1[i] == '0') { nulle = nulle + 1;nnn[0] = nulle;}
            }
            nulle = 0;
            for (int i = 0; i < sz2.Length; i++)
            {
                if (sz2[i] == '0') { nulle = nulle + 1; nnn[1] = nulle;}
            }
            nulle = 0;
            for (int i = 0; i < sz3.Length; i++)
            {
                if (sz3[i] == '0') { nulle = nulle + 1; nnn[2] = nulle;}
            }
            nulle = 0;
            for (int i = 0; i < sz4.Length; i++)
            {
                if (sz4[i] == '0') { nulle = nulle + 1; nnn[3] = nulle;}
            }
            nulle = 0;
            for (int i = 0; i < sz5.Length; i++)
            {
                if (sz5[i] == '0') { nulle = nulle + 1; nnn[4] = nulle;}
            }
            nulle = 0;
            for (int i = 0; i < sz6.Length; i++)
            {
                if (sz6[i] == '0') { nulle = nulle + 1; nnn[5] = nulle;}
            }
            nulle = 0;
            for (int i = 0; i < sz7.Length; i++)
            {
                if (sz7[i] == '0') { nulle = nulle + 1; nnn[6] = nulle;}
            }
            nulle = 0;
            for (int i = 0; i < sz8.Length; i++)
            {
                if (sz8[i] == '0') { nulle = nulle + 1; nnn[7] = nulle;}
            }
            nulle = 0;
            for (int i = 0; i < sz9.Length; i++)
            {
                if (sz9[i] == '0') { nulle = nulle + 1; nnn[8] = nulle;}
            }
            nulle = 0;
            for (int i = 0; i < sz10.Length; i++)
            {
                if (sz10[i] == '0') { nulle = nulle + 1; nnn[9] = nulle;}
            }
            nulle = 0;
            for (int i = 0; i < nnn.Length; i++)
            {
                if (nnn[i] > nulla)
                {
                    nulla = nnn[i];
                    for (int k = 0; k < i; k++)
                    {
                        if (nulla == nnn[i])
                        {
                            ered = Convert.ToString(k);
                        }
                    }
                }
            }
        }
        public void kiir()
        {
            Console.WriteLine("A {0} számban van a legtöbb nulla!\nNullák száma: {1}",ered, nulla);
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Nulls megold = new Nulls();
            megold.randoms();
            megold.lengts();
            megold.kiir();
            Console.ReadKey();
        }
    }
}
