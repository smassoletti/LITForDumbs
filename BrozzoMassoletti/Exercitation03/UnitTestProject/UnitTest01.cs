using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise01;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest01
    {
        [TestMethod]
        public void TestGTN()
        {
            Assert.AreEqual(false, GTNMethods.GTN(new int[] { 1, 4, 2, 5, 9, 3, 14, 7 }, 0));
            Assert.AreEqual(true, GTNMethods.GTN(new int[] { 1, 4, 2, 5, 9, 3, 14, 7 }, 1));
            Assert.AreEqual(true, GTNMethods.GTN(new int[] { 1, 4, 2, 5, 9, 3, 14, 7 }, 4));
            Assert.AreEqual(true, GTNMethods.GTN(new int[] { 1, 4, 2, 5, 9, 3, 14, 7 }, 6));
            Assert.AreEqual(false, GTNMethods.GTN(new int[] { 1, 4, 2, 5, 9, 3, 14, 7 }, 7));

        }

        [TestMethod]
        public void TestGTNFind()
        {
            Assert.AreEqual( 1, GTNMethods.GTNFind(new int[] { 1, 4, 2, 5, 9, 3, 14, 7 }));
            Assert.AreEqual(-1, GTNMethods.GTNFind(new int[] { 0, 0, 0, 0, 0, 0, 0, 0 }));
            Assert.AreEqual( 7, GTNMethods.GTNFind(new int[] { 8, 8, 8, 8, 9, 10, 11, 12 }));
            Assert.AreEqual(-1, GTNMethods.GTNFind(new int[] { -3, -3, -3, -3, -3, -3, -3, -3 }));
            Assert.AreEqual( 0, GTNMethods.GTNFind(new int[] { 4, 1, 2, 5, 9, 3, 14, 7 }));

        }
    }
}
