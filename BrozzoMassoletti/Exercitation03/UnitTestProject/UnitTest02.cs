using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise02;


namespace UnitTestProject
{
    [TestClass]
    public class UnitTest02
    {
        [TestMethod]
        public void TestLongSumGeneric()
        {
            byte[] number1 = new byte[5] { 1, 5, 4, 9, 6 };
            byte[] number2 = new byte[7] { 4, 8, 1, 2, 0, 0, 2 };
            byte[] expectedResult = new byte[7] { 4, 8, 2, 7, 4, 9, 8 };
            byte[] sum = VeryLongUInt.VeryLongUIntSum(number1, number2);

            CollectionAssert.AreEqual(sum, expectedResult);
        }

        [TestMethod]
        public void TestLongSumZerosBeforeNumber()
        {
            byte[] number1 = new byte[4] { 0, 4, 5, 2 };
            byte[] number2 = new byte[5] { 0, 0, 0, 3, 4 };
            byte[] expectedResult = new byte[3] { 4, 8, 6 };
            byte[] sum = VeryLongUInt.VeryLongUIntSum(number1, number2);

            CollectionAssert.AreEqual(sum, expectedResult);
        }

        [TestMethod]
        public void TestLongSumZero()
        {
            byte[] number1 = new byte[1] { 0 };
            byte[] number2 = new byte[1] { 0 };
            byte[] expectedResult = new byte[1] { 0 };
            byte[] sum = VeryLongUInt.VeryLongUIntSum(number1, number2);

            CollectionAssert.AreEqual(sum, expectedResult);
        }
    }
}
