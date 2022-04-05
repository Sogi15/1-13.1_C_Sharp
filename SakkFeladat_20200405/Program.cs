using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakkFeladat_20200405
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tablaX = new string[8] { "1", "2", "3", "4", "5", "6", "7", "8", },
                tablaY = new string[8] { "a", "b", "c", "d", "e", "f", "g", "h" };
            bool bastya = true;
            string position = string.Empty;
            if (position == tablaX[7]+tablaY[1])
            {
                bastya = true;
            }
            else { bastya = false; }
            
        }
    }
}
