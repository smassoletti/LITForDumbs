using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise09;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest09
    {
        [TestMethod]
        public void TestExtract()
        {
            string input = @"Please contact us by phone (+001 222 222 222) or by email at example@gmail.com or at test.user@yahoo.co.uk. This is not email: test@test. This also: @gmail.com. Neither this: a@a.b.";
            string[] emails = EmailFinder.ExtractEmail(input);
            Assert.AreEqual("example@gmail.com", emails[0]);
            Assert.AreEqual("test.user@yahoo.co.uk", emails[1]);
        }
    }
}
