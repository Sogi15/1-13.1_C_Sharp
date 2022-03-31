using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binaris
{
    class Bin
    {

        private string bekeres = "";
        private int db = 0;

        public Bin() { }
        public void megoldas()
        {
            Console.WriteLine("Írj be egy bináris számsorozatot! (pld: 0101)");
            bekeres = Console.ReadLine();
            for (int i = 0; i < bekeres.Length; i++)
            {
                if (bekeres[i] == '1')
                {
                    db += 1;
                }
            }
            Console.WriteLine("{0}db 1-es található a bináris számban amit beírtál!", db);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bin megold = new Bin();
            megold.megoldas();
            Console.ReadKey();
        }
    }
}
