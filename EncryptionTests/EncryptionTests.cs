using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EncryptionClassLibrary;

namespace EncryptionTests
{
    [TestClass]
    public class EncryptionTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            string str = "мышь ";
            string key = "мышь";

            string expected = "ряьа ";
            //act
            string actual = EncryptionClass.Encryption(str, key);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //arrange
            string str = "";
            string key = "мышь";

            string expected = "";
            //act
            string actual = EncryptionClass.Encryption(str, key);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
