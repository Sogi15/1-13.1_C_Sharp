using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto_gyakorlas
{
    class Lotto
    {
        private string tippek;
        private int[] ertekek;
        private int dbszam,lotto;
        private Random rdm = new Random();
        public Lotto() { }
        // Lottó sorsolás választása (5/6/7 lottó)
        public void lottozzunk()
        {
            Console.WriteLine("Üdvözöllek a játékban!\nVálassz melyik lottót szeretnéd játszani?\nÖtös = 5 | Hatos = 6| Hetes = 7");
            lotto = int.Parse(Console.ReadLine());
            if (lotto < 5 && lotto > 7)
            {
                Console.WriteLine("Kérlek az 5/6/7-es számok közül válassz!\nIlletve ne karaktert írj be!");
                lotto = int.Parse(Console.ReadLine());
            }
            else
            {
                // lottókon belül a sorsolás max értékének megadása
                if (lotto == 5) { dbszam = 90;}
                else if (lotto == 6){dbszam = 45;}
                else if (lotto == 7){dbszam = 35;}
                ertekek = new int[lotto];
                // lottó kisorsolása
                for (int i = 0; i < ertekek.Length; i++)
                {
                    ertekek[i] = rdm.Next(1,dbszam);
                }
                // tippek bekérése
                Console.WriteLine("Kérlek írj be {0}db számot vesszővel elválasztva!",lotto);
                tippek = Console.ReadLine();
                tippek = String.Concat(tippek.Where(c => !Char.IsWhiteSpace(c)));

                //foreach (var lottozo in ertekek)
                //{
                //    Console.WriteLine(lottozo);
                //}
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Lotto megold = new Lotto();
            megold.lottozzunk();
            Console.ReadKey();
        }
    }
}
