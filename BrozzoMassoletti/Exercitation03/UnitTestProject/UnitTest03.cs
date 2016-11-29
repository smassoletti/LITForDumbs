using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise03;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest03
    {
        [TestMethod]
        public void TestSafeTraverser()
        {
            string path = @"C:\windows\system32";
            List<string> filesAndFolders = FolderTraverse.GetFilesSAFE(path);
        }
        public void TestFolderKnown()
        {
            string path = @"..\..\..\Exercise03\TestFolder";
            List<string> filesAndFolders = FolderTraverse.GetFiles(path);
            Assert.AreEqual(8, filesAndFolders.Count);
        }
        [TestMethod]
        [ExpectedException(typeof(UnauthorizedAccessException))]
        public void TestUnsafeTraverser()
        {
            string path = @"C:\windows\system32";
            List<string> filesAndFolders = FolderTraverse.GetFiles(path);
        }
    }
}
