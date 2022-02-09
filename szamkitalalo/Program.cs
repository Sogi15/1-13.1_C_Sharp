using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamkitalalo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Változók
            int alsohatar = 1, //Véletlen szám alsó határa
                felsohatar = 100, //Véletlen szám felső határa
                probal = 5; //Próbálkozások maximális száma
            
            Random rnd = new Random();

            //Játék ismétlése
            do
            {
                //Megkérdezem, hogy ki lesz a kitaláló
                Console.WriteLine("Leszel az aki gondol egy számra? (i/n)");
                if (Console.ReadKey(true).KeyChar == 'n')
                {
                //Ha a játékos a kitaláló
                //A gép gondol egy számot és a játékosnak kell kitalálni, max 5 próbálkozás.
                //tipp beírása
                //ha nagyobb a tipp.
                //Ha kisebb a tipp.
                //ha pontos a tipp.
                //ha k/n akkor uj tipp iras
                }
                else
                {
                //Ha a gép a kitaláló
                //A Játékos gondol egy számot és a játékosnak kell kitalálni, max 5 próbálkozás.
                //szám meghatározása
                //ha nagyobb a tipp.
                //Ha kisebb a tipp.
                //ha pontos a tipp.
                //ha k/n akkor uj tipp kiertekeles
                }
                //kérdés h akarsz-e újra játszani
                Console.WriteLine("Folytatjuk a játékot? (i/n)");
            } while (Console.ReadKey(true).KeyChar == 'i');
            // sor kiirtekeles
            Console.ReadKey();

        }
    }
}
