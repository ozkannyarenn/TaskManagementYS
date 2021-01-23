using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using istakipProgrami;
namespace whiteBoxBirimTest
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            Proje prj = new Proje();
            prj.Id = 1;
            prj.Projeİsmi = "asdfda";
            prj.Musteri = "adsfads";
            prj.Bilgi = "asdfdsadads";
        }
    }
}
