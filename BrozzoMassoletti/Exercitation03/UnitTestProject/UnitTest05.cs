using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise05;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest05
    {
        private bool StringFinder(string adstr, string[] adarray)
        {
            bool flag = false;
            foreach (string compare in adarray)
            {
                flag = adstr.Contains(compare);
                if (flag == true)
                    break;
            }

            return flag;
        }

        [TestMethod]
        public void TestDifferent()
        {
            Assert.AreNotEqual(RandomAds.MessageGenerator(), RandomAds.MessageGenerator());
        }

        [TestMethod]
        public void TestDifferentLoop()
        {
            for (double i = 0; i < sizeof(double); i++)
                Assert.AreNotEqual(RandomAds.MessageGenerator(), RandomAds.MessageGenerator());
        }

        [TestMethod]
        public void IsComplete()
        {
            string sentence = RandomAds.MessageGenerator();

            Assert.IsTrue(StringFinder(sentence, RandomAds.Phrases));
            Assert.IsTrue(StringFinder(sentence, RandomAds.Stories));
            Assert.IsTrue(StringFinder(sentence, RandomAds.FirstNames));
            Assert.IsTrue(StringFinder(sentence, RandomAds.LastNames));
            Assert.IsTrue(StringFinder(sentence, RandomAds.Cities));

        }
    }
}

