using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Binaris;

namespace Binaris_unitteszt
{
    [TestClass]
    public class Binaris_teszt
    {
        //Arrange
        static string megold = "01000001010111111110011011"; //Itt kell megadni a bekért számsort (fontos, hogy tudjuk hány db 1est írtunk a teszt végett!)
        Bin szam = new Bin(megold);

        [TestMethod]
        public void BinarisTeszt()
        {
            //Arrange
            int varteredmeny = 15; //Mivel a megadott számsorban 15db 1-est tettem így ha a program helyesen fut akkor passed lesz a teszt!
            //ACT
            int kapotteredmeny = szam.megoldas();
            //Assert
            Assert.AreEqual(kapotteredmeny, varteredmeny);
        }
    }
}
