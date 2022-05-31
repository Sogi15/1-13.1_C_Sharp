using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SzigetekUT;

namespace Szigetek_unitteszt
{
    [TestClass]
    public class UnitTest1
    {
        static string Cords = "0011111111111111100110101110110011111111011101110111"; //15-9
        Island megold = new Island(Cords);
        [TestMethod]
        public void TestSzigetCount()
        {
            //Arrange
            var vart = 9;
            //ACT
            var kapott = megold.SzN();
            //Assert
            Assert.AreEqual(vart, kapott);
        }
        [TestMethod]
        public void TestSzigetLength()
        {
            //Arrange
            var vart = 15;
            //ACT
            var kapott = megold.SzH();
            //Assert
            Assert.AreEqual(vart, kapott);

        }
    }
}
