using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using istakipProgrami;
namespace whiteBoxBirimTest
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            Kullanici kul = new Kullanici();
            kul.Adi = "Yeni";
            kul.Soyadi = "Hesap";
            kul.KullaniciAdi = "yeniHesap123";
            kul.Parola = "123";
        }
    }
}
