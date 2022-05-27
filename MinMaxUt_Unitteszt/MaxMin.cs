using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MinMaxUt;

namespace MinMaxUt_Unitteszt
{
    [TestClass]
    public class MaxMin
    {
        static int[] szamok = new int[] {12,18,69,8,15};
        MM megold = new MM(5,false,szamok);
        [TestMethod]
        public void Minimum()
        {
            //Arrange
            megold.feltolt_sajat();
            var vart = 8; // a megadott számok közül a 8 a legkissebb!
            //Act
            var kapott = megold.getMin();
            //Assert
            Assert.AreEqual(vart, kapott);
        }
        [TestMethod]
        public void Maximumum()
        {
            //Arrange
            megold.feltolt_sajat();
            var vart = 69; // a megadott számok közül a 69 a legnagyobb!
            //Act
            var kapott = megold.getMax();
            //Assert
            Assert.AreEqual(vart, kapott);
        }
    }
}
