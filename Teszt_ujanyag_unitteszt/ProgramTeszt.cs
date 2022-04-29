using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Teszt_ujanyag_unitteszt
{
    [TestClass]
    public class ProgramTeszt
    {
        [TestMethod]
        public void TesztUjanyag()
        {
            //Arrange
            string varteredmeny = "Helló világ!";
            //ACT
            using (var sw = new StringWriter()) { Console.SetOut(sw); //Konzol átírányítása sw-be
            Teszt_ujanyag.Program.Main();
            var kapotteredmeny = sw.ToString().Trim();
                //Assert
                Assert.AreEqual(kapotteredmeny, varteredmeny);
            }

        }
    }
}
