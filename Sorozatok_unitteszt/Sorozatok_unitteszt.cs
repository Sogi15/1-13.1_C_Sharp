using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Sorozatok;

namespace Sorozatok_unitteszt
{
    [TestClass]
    public class Sorozatok_unitteszt
    {
        Sorozat megold = new Sorozat(2,4,6,8);
        [TestMethod]
        public void SorozatokTeszt()
        {
            //Arrange

            //Ha true akkor számtani!
            var szamtani = true; //Ha false =  mértani sorozat vagy egyik sorozatnak sem a része!
            //Arc
            var kiadott = megold.megold();
            //Assert
            Assert.AreEqual(szamtani,kiadott);
        }
    }
}
