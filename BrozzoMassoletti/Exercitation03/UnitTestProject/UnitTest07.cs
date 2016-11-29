using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise07;
using System.IO;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest07
    {
        [TestMethod]
        public void TestSaveFile()
        {
            WebDownload.SaveFile("http://i.imgur.com/JCmmlGm.png");
            Assert.IsTrue(File.Exists("JCmmlGm.png"));
        }
        [TestMethod]
        [ExpectedException(typeof(DownloadException))]
        public void TestDownloadFileFromInternetException()
        {
            WebDownload.SaveFile("http://www.esercizic#risolti.it/SoluzioneEsercitazioni.jpg");
        }

    }
}
