using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Negyszog;

namespace Negyszog_teszt
{
    [TestClass]
    public class NegyszogTeszt
    {
        // Arrange
        static double s = 2.0;
        Nszog nsz = new Nszog(s);

        [TestMethod]
        public void TesztKerulet()
        {
            //Arrange
            double varteredmeny = 8.0;
            //ACT
            double kapotteredmeny = nsz.Kerulet();
            //Assert
            Assert.AreEqual(varteredmeny,kapotteredmeny);
        }
        [TestMethod]
        public void TesztTerulet()
        {
            //Arrange
            double varteredmeny = 4;
            //ACT
            double kapotteredmeny = nsz.Terulet();
            //Assert
            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }
        [TestMethod]
        public void TesztAtlo()
        {
            //Arrange
            double varteredmeny = Math.Sqrt(8);
            //ACT
            double kapotteredmeny = nsz.Atlo();
            //Assert
            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void TesztOszlop()
        {
            //ACT
            double m = 0; //ezt nem helyes érték
            //Assert
            nsz.setOszlop(m);
        }
    }
}
