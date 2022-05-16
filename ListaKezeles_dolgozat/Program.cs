﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaKezeles_dolgozat
{
    class Cityes
    {
        private int nevszam = 0;
        private string szerepel = string.Empty;
        private char i;
        private List<string> varosok;
        public Cityes() { }
        public void setDb()
        {
            try
            {
                Console.WriteLine("Add meg a városok nevének a számát!");
                nevszam = int.Parse(Console.ReadLine());
            }
            catch (FormatException e1)
            {
                Console.WriteLine(e1.Message);
                Console.WriteLine("Add meg a városok nevének a számát!");
                nevszam = int.Parse(Console.ReadLine());
                throw;
            }
        }
        public void setNevek()
        {
                varosok = new List<string>(nevszam);
                for (int i = 0; i < nevszam; i++)
                {
                    Console.WriteLine("Add meg a {0}. város nevét", i + 1);
                    szerepel = Console.ReadLine();
                    varosok.Add(szerepel);
                }
        }
        public void getNevek()
        {
            Console.WriteLine("A Listában megtalálható városok:");
            foreach (var varos in varosok)
            {
                Console.Write("{0}, ", varos);
            }
        }
        public void getVan()
        {
            Console.WriteLine("\nÍrj be egy városnevet hátha szerepel már a listában!");
            szerepel = Console.ReadLine();
            if (varosok.Contains(szerepel))
            {
                Console.WriteLine("A {0} nevű város szerepel a listában!", szerepel);
            }
            else
            {
                Console.WriteLine("A {0} nevű város sajnos nem található a listában!",szerepel);
            }
        }
        public void delNev()
        {
            Console.WriteLine("Kérlek írj be egy városnevet!\nHa szerepel a listában törlődni fog!\nHa nem akkor hozzá adódik!");
            szerepel = Console.ReadLine();
            if (varosok.Contains(szerepel))
            {
                Console.WriteLine("A {0} nevű város szerepel a listában! Ezért töröljük!", szerepel);
                varosok.Remove(szerepel);
                getNevek();
            }
            else
            {
                Console.WriteLine("A {0} nevű város nem található a listában! Ezért hozzáadjuk!", szerepel);
                varosok.Add(szerepel);
                getNevek();
            }
        }
        public void delLast()
        {
            Console.WriteLine("\nSzeretnéd, hogy töröljük a listában található utolsó elemet?\ni = igen | n = nem");
            try
            {
                i = Console.ReadKey().KeyChar;
                if (i != 'i' && i != 'n')
                {
                    Console.WriteLine("\nKérlek csak i|n betűket használj!");
                    i = Console.ReadKey().KeyChar;
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("\nKérlek csak i|n betűket használj!");
                i = Console.ReadKey().KeyChar;
                throw;
            }
            if (i == 'i')
            {
                varosok.RemoveAt(varosok.Count - 1);
                Console.WriteLine();
                getNevek();
            }
            else
            {
                Console.WriteLine();
                getNevek();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cityes megold = new Cityes();
            megold.setDb();
            megold.setNevek();
            megold.getNevek();
            megold.getVan();
            megold.delNev();
            megold.delLast();
            Console.ReadKey();
        }
    }
}
