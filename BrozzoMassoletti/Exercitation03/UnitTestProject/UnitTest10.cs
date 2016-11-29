using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise10;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest10
    {
        [TestMethod]
        public void TestTable()
        {
            string input = "Uno nove due sette zeRo sei sETte TRE Sette due tre quaTtro CINQUE cinque";
            SortedDictionary<string, int> expectedTable = new SortedDictionary<string, int>();
            expectedTable.Add("cinque", 2);
            expectedTable.Add("due", 2);
            expectedTable.Add("nove", 1);
            expectedTable.Add("quattro", 1);
            expectedTable.Add("sei", 1);
            expectedTable.Add("sette", 3);
            expectedTable.Add("tre", 2);
            expectedTable.Add("uno", 1);
            expectedTable.Add("zero", 1);
            CollectionAssert.AreEqual(expectedTable, WordsTable.WordTableConstructor(input));
        }
    }
}
