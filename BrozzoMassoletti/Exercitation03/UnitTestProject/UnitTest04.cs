using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise04;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest04
    {
        [TestMethod]
        public void TestDatesEqual()
        {
            Assert.AreEqual(1, Exercise04.WorkDays.CountWorkDays(new DateTime(2018, 12, 3), new DateTime(2018, 12, 3)));
        }

        [TestMethod]
        public void TestDatesEarlier()
        {
            Assert.AreEqual(null, Exercise04.WorkDays.CountWorkDays(new DateTime(2018, 12, 3), new DateTime(2010, 12, 3)));
        }

        //Here I compared the result of my function with the one I found using http://www.giorni-lavorativi.com/
        [TestMethod]
        public void TestDatesDistant()
        {
            Assert.AreEqual(1693, Exercise04.WorkDays.CountWorkDays(new DateTime(2012, 3, 15), new DateTime(2018, 11, 28)));
        }
    }
}
