using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using KalkulatorUt;

namespace KalkulatorUt_Unitteszt
{
    [TestClass]
    public class CalcUt
    {
        static int tszam1 = 10;
        static int tszam2 = 5;
        static char a = '+', b = '-', c = '/', d = '*';

        Calc ax = new Calc(tszam1, tszam2, a);
        Calc bx = new Calc(tszam1, tszam2, b);
        Calc cx = new Calc(tszam1, tszam2, c);
        Calc dx = new Calc(tszam1, tszam2, d);
        Calc xx = new Calc(tszam1, 0, c);
        [TestMethod]
        public void TesztOsszead()
        {
            //Arrange
            var vart = tszam1 + tszam2; //15
            //Act
            var kapott = ax.Megoldas();
            //Assert
            Assert.AreEqual(vart, kapott);
        }
        [TestMethod]
        public void TesztKivon()
        {
            //Arrange
            var vart = tszam1 - tszam2; //5
            //Act
            var kapott = bx.Megoldas();
            //Assert
            Assert.AreEqual(vart, kapott);
        }
        [TestMethod]
        public void TesztSzor()
        {
            //Arrange
            var vart = tszam1 * tszam2; //50
            //Act
            var kapott = dx.Megoldas();
            //Assert
            Assert.AreEqual(vart, kapott);
        }
        [TestMethod]
        public void TesztOszt()
        {
            //Arrange
            var vart = tszam1 / tszam2; //2
            //Act
            var kapott = cx.Megoldas();
            //Assert
            Assert.AreEqual(vart, kapott);
        }
        [TestMethod]
        public void TesztNullOszt()
        {
            //Arrange
            var vart = 15; // Nullával való osztás nem lehetséges!
            //Act
            var kapott = xx.Megoldas();
            //Assert
            Assert.AreNotEqual(vart, kapott);
        }

    }
}
