using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Exercise06;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest06
    {
        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void TestNonExistingFile()
        {
            FileParse.FileParsing("foo");
        }

        [TestMethod]
        [ExpectedException(typeof(FileParseException))]
        public void TestWrongFormat()
        {
            string fileName = "wrong";
            using (StreamWriter file = File.AppendText(fileName))
            {
                file.WriteLine("4");
                file.WriteLine("15");
                file.WriteLine("ff");
                file.WriteLine("7");
            }
            FileParse.FileParsing(fileName);
        }
    }
}
