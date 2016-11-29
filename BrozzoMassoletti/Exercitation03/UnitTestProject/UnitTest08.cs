using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise08;
using System.Text;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest08
    {
        [TestMethod]
        public void TestEncryption()
        {
            ushort[] encrypted = EncryptText.Encrypt("Test", "ab");
            StringBuilder encryptedString = new StringBuilder();
            foreach (ushort character in EncryptText.Encrypt("Test", "ab"))
            {
                encryptedString.AppendFormat("\\u{0:x4}", character);
            }
            Assert.AreEqual("\\u0035\\u0007\\u0012\\u0016", encryptedString.ToString());
        }
    }
}
