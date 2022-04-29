﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negyszog
{
    public class Nszog
    {
        // Tagváltozók
        public double Side { get; set; }
        private double oszlop;

        // Konstruktor
        public Nszog(double side)
        {
            this.Side = side;
        }

        //Kerület
        public double Kerulet() {
            return 4 * this.Side;
        }

        //Terület
        public double Terulet()
        {
            return Math.Pow(this.Side, 2);
        }
        //Átló
        public double Atlo()
        {
            return Math.Sqrt(Math.Pow(this.Side, 2) * 2);
        }
        //Oszlop méretének beolvasása
        public void setOszlop(double magas)
        {
            // Az oszlop nem lehet negatív
            if (magas <= 0)
            {
                throw new ArgumentException("A magasság nem lehet 0 vagy negatív");
            }
            else this.oszlop = magas;
            
    }
        
    }
}
