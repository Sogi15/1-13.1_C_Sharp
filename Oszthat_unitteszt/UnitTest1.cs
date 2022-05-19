using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Oszthat;

namespace Oszthat_unitteszt
{
    [TestClass]

    public class UnitTest1
    {
        // arrange
        Osztogep megold1 = new Osztogep(5);
        Osztogep megold2 = new Osztogep(3);
        Osztogep megold3 = new Osztogep(15);

        //3 ha azt várjuk eredmény 3 legyen. 5 ha eredmény 5 legyen 15 ha mindkettő!
        [TestMethod]
        public void Oszthatóteszt()
        {
            string a = "Öt", b = "Három", c = "Három | Öt"; // teszt string változók
            //arrange 
            string vartmegold1 = a;
            string vartmegold2 = b;
            string vartmegold3 = c;
            //act
            string kapottmegold1 = megold1.getSzam();
            string kapottmegold2 = megold2.getSzam();
            string kapottmegold3 = megold3.getSzam();
            //assert
            Assert.AreEqual(vartmegold1, kapottmegold1);
            Assert.AreEqual(vartmegold2, kapottmegold2);
            Assert.AreEqual(vartmegold3, kapottmegold3);
        }
    }
}
