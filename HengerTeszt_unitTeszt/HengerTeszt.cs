using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Henger;

namespace HengerTeszt_unitTeszt
{
    [TestClass]
    public class HengerTeszt
    {
        //Arrange
        static double r = 2.0;
        static double m = 2.0;
        Hengert megold = new Hengert(r,m);

        [TestMethod]
        public void TesztTerfogat()
        {
            //Arrange
            double varteredmeny = Math.PI*Math.Pow(r,2)*m;
            //ACT
            double kapotteredmeny = megold.getTerfogat();
            //Assett
            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }
        [TestMethod]
        public void TesztFelszin()
        {
            //Arrange
            double varteredmeny = 2 * Math.PI * r * (r + m);
            //ACT
            double kapotteredmeny = megold.getFelszin();
            //Assett
            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }
        [TestMethod]
        public void TesztKerulet()
        {
            //Arrange
            double varteredmeny = 2 * Math.PI * r;
            //ACT
            double kapotteredmeny = megold.getKerulet();
            //Assett
            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }
        [TestMethod]
        public void TesztTerulet()
        {
            //Arrange
            double varteredmeny = Math.PI * Math.Pow(r, 2);
            //ACT
            double kapotteredmeny = megold.getTerulet();
            //Assett
            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }
    }
}
