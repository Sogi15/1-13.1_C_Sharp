﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamkiiras
{
    class Program
    {
        static void Main(string[] args)
        {
            string szam = "",
                   szam1 = "",
                   szam2 = "",
                   szam3 = "";
              
            
            string[] ertek1 = new string[] { "nulla", "egy", "kettő", "három", "négy", "öt", "hat", "hét", "nyolc", "kilenc", "tiz" };
            string[] ertek2 = new string[] { "tizen", "huszon", "harminc", "negyven", "ötven", "hatvan", "hetven", "nyolcvan", "kilencven" };
            string[] ertek3 = new string[] { "száz", "kétszáz", "ezer"};
            Console.WriteLine("Kérlek írj be egy számot! (990-1000ig)");
            szam = Console.ReadLine();
            if (szam.Length != 5)
            {
                for (int i = 0; i < szam.Length; i++)
                {
                    if (szam.Length == 1)
                    {
                        switch (szam[0])
                        {
                            case '0': szam1 = ertek1[0]; break;
                            case '1': szam1 = ertek1[1]; break;
                            case '2': szam1 = ertek1[2]; break;
                            case '3': szam1 = ertek1[3]; break;
                            case '4': szam1 = ertek1[4]; break;
                            case '5': szam1 = ertek1[5]; break;
                            case '6': szam1 = ertek1[6]; break;
                            case '7': szam1 = ertek1[7]; break;
                            case '8': szam1 = ertek1[8]; break;
                            case '9': szam1 = ertek1[9]; break;
                        }
                    }
                    if (szam.Length == 2)
                    {
                        switch (szam[0])
                        {
                            case '1': szam1 = ertek2[0]; break;
                            case '2': szam1 = ertek2[1]; break;
                            case '3': szam1 = ertek2[2]; break;
                            case '4': szam1 = ertek2[3]; break;
                            case '5': szam1 = ertek2[4]; break;
                            case '6': szam1 = ertek2[5]; break;
                            case '7': szam1 = ertek2[6]; break;
                            case '8': szam1 = ertek2[7]; break;
                            case '9': szam1 = ertek2[8]; break;
                        }
                        switch (szam[1])
                        {
                            case '0': szam2 = ertek1[0]; break;
                            case '1': szam2 = ertek1[1]; break;
                            case '2': szam2 = ertek1[2]; break;
                            case '3': szam2 = ertek1[3]; break;
                            case '4': szam2 = ertek1[4]; break;
                            case '5': szam2 = ertek1[5]; break;
                            case '6': szam2 = ertek1[6]; break;
                            case '7': szam2 = ertek1[7]; break;
                            case '8': szam2 = ertek1[8]; break;
                            case '9': szam2 = ertek1[9]; break;
                        }
                        szam1 = szam1 + szam2;
                    }
                    if (szam.Length == 3)
                    {
                        switch (szam[0])
                        {
                            case '1': szam1 = ertek3[0]; break;
                            case '2': szam1 = ertek3[1]; break;
                            case '3': szam1 = ertek1[3] + ertek3[0]; break;
                            case '4': szam1 = ertek1[4] + ertek3[0]; break;
                            case '5': szam1 = ertek1[5] + ertek3[0]; break;
                            case '6': szam1 = ertek1[6] + ertek3[0]; break;
                            case '7': szam1 = ertek1[7] + ertek3[0]; break;
                            case '8': szam1 = ertek1[8] + ertek3[0]; break;
                            case '9': szam1 = ertek1[9] + ertek3[0]; break;
                        }
                        switch (szam[1])
                        {
                            case '1': szam2 = ertek2[0]; break;
                            case '2': szam2 = ertek2[1]; break;
                            case '3': szam2 = ertek2[2]; break;
                            case '4': szam2 = ertek2[3]; break;
                            case '5': szam2 = ertek2[4]; break;
                            case '6': szam2 = ertek2[5]; break;
                            case '7': szam2 = ertek2[6]; break;
                            case '8': szam2 = ertek2[7]; break;
                            case '9': szam2 = ertek2[8]; break;
                        }
                        switch (szam[2])
                        {
                            case '0': szam3 = ertek1[0]; break;
                            case '1': szam3 = ertek1[1]; break;
                            case '2': szam3 = ertek1[2]; break;
                            case '3': szam3 = ertek1[3]; break;
                            case '4': szam3 = ertek1[4]; break;
                            case '5': szam3 = ertek1[5]; break;
                            case '6': szam3 = ertek1[6]; break;
                            case '7': szam3 = ertek1[7]; break;
                            case '8': szam3 = ertek1[8]; break;
                            case '9': szam3 = ertek1[9]; break;
                        }
                        szam1 = szam1 + szam2 + szam3;
                    }
                    if (szam.Length == 4)
                    {
                        switch (szam[0])
                        {
                            case '1': szam1 = ertek3[0]; break;
                            case '2': szam1 = ertek3[1]; break;
                            case '3': szam1 = ertek1[3] + ertek3[0]; break;
                            case '4': szam1 = ertek1[4] + ertek3[0]; break;
                            case '5': szam1 = ertek1[5] + ertek3[0]; break;
                            case '6': szam1 = ertek1[6] + ertek3[0]; break;
                            case '7': szam1 = ertek1[7] + ertek3[0]; break;
                            case '8': szam1 = ertek1[8] + ertek3[0]; break;
                            case '9': szam1 = ertek1[9] + ertek3[0]; break;
                        }
                        switch (szam[1])
                        {
                            case '1': szam2 = ertek2[0]; break;
                            case '2': szam2 = ertek2[1]; break;
                            case '3': szam2 = ertek2[2]; break;
                            case '4': szam2 = ertek2[3]; break;
                            case '5': szam2 = ertek2[4]; break;
                            case '6': szam2 = ertek2[5]; break;
                            case '7': szam2 = ertek2[6]; break;
                            case '8': szam2 = ertek2[7]; break;
                            case '9': szam2 = ertek2[8]; break;
                        }
                        switch (szam[2])
                        {
                            case '0': szam3 = ertek1[0]; break;
                            case '1': szam3 = ertek1[1]; break;
                            case '2': szam3 = ertek1[2]; break;
                            case '3': szam3 = ertek1[3]; break;
                            case '4': szam3 = ertek1[4]; break;
                            case '5': szam3 = ertek1[5]; break;
                            case '6': szam3 = ertek1[6]; break;
                            case '7': szam3 = ertek1[7]; break;
                            case '8': szam3 = ertek1[8]; break;
                            case '9': szam3 = ertek1[9]; break;
                        }
                        szam1 = szam1 + szam2 + szam3;
                    }
                }
                Console.WriteLine("{0}", szam1);
            }
            else
            {
                Console.WriteLine("Kérlek 1000 alatti és 0 feletti számot adj meg!");
            }
            Console.ReadKey();
        }
    }

}
