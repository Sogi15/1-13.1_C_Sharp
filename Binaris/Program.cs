using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binaris
{
    public class Bin
    {

        private string bekeres = string.Empty;
        private int db = 0;
        public Bin(string bekeres)
        {
            this.bekeres = bekeres;
        }
        public int megoldas()
        {
            for (int i = 0; i < this.bekeres.Length; i++)
            {
                if (this.bekeres[i] == '1')
                {
                    db += 1;
                }
            }
            Console.WriteLine("{0}db 1-es található a bináris számban amit beírtál!", db);
            return db;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írj be egy bináris számsorozatot! (pld: 0101)");
            Bin megold = new Bin(Console.ReadLine());
            megold.megoldas();
            Console.ReadKey();
        }
    }
}
