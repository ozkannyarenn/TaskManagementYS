using istakipProgrami;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace whiteBoxBirimTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Gorev gorevler = new Gorev();
            gorevler.Aciklama = "dasfdas";
            gorevler.Baslik = "adsfadsfad";
            gorevler.Id = 1;
        }
    }
}
