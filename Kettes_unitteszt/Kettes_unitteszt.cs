using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Kettes;

namespace Kettes_unitteszt
{
    [TestClass]
    public class Kettes_unitteszt
    {
        //Arrange
        static int szam = 20; //20as számot írjuk át számrendszerbe
        Kszam megold = new Kszam(szam);
        [TestMethod]
        public void TesztKettes()
        {
            //Arrange
            string varteredmeny = "10100";  // 10100 lesz 20 a 2-es számrendszerben.
            //Act
            string kapotteredmeny = megold.kksz();
            //Assert
            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }
    }
}
