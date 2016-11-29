using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise01;

namespace UnitTestProject
{
    [TestClass]
    public class GSMCallHistoryTest
    {
        public GSM MotoG;
        [TestInitialize]
        public void Startup()
        {
            MotoG = new GSM("MotoG", "Motorola", 20.0f, "Stefano", new Battery("GHMTG38", "Up to 2h", 1), new Display(1, 64));
            MotoG.AddCall("3401239999", 47);
            MotoG.AddCall("113", 22);
            MotoG.AddCall("118", 123);
            MotoG.AddCall("911", 60);
            MotoG.AddCall("190", 200);
        }
        [TestMethod]
        public void BatteryClassTest()
        {
            Assert.AreEqual("GHMTG38", MotoG.Battery.Model);
            Assert.AreEqual("Up to 2h", MotoG.Battery.Idle);
            Assert.AreEqual(1, MotoG.Battery.Talkhours);
        }
        [TestMethod]
        public void DisplayClassTest()
        {
            Assert.AreEqual(1, MotoG.Display.Size);
            Assert.AreEqual(64, MotoG.Display.Colors);
        }
        [TestMethod]
        public void GSMClassTest()
        {
            Assert.AreEqual("Model: MotoG\r\nManufacturer: Motorola\r\nPrice: 20\r\nOwner: Stefano\r\nBattery: Exercise01.Battery\r\nDisplay: Exercise01.Display\r\n", MotoG.ToString());
        }
        [TestMethod]
        public void AddCall()
        {
            int temp = MotoG.CallHistory.Count;
            MotoG.AddCall("123123123", 18);
            Assert.AreEqual(temp + 1, MotoG.CallHistory.Count);
        }
        [TestMethod]
        public void CostCall()
        {
            Assert.AreEqual((0.37M * (60 + 20 + 120)), MotoG.PriceCall(0.37M));
        }
        [TestMethod]
        public void RemoveLongestCall()
        {
            MotoG.DeleteCall(200);
            Assert.AreEqual(4, MotoG.CallHistory.Count);
        }
        [TestMethod]
        public void RemoveCallNumber()
        {
            MotoG.DeleteCall("911");
            Assert.AreEqual(4, MotoG.CallHistory.Count);
        }
        [TestMethod]
        public void ClearArchive()
        {
            MotoG.DeleteCallList();
            Assert.AreEqual(0, MotoG.CallHistory.Count);
        }

    }
}
