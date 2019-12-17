using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClockAngle.Models;

namespace Program.Tests
{
    [TestClass]
    public class ClockTest
    {
        [TestMethod]
        public void CalcDegree_Is0Deg_0()
        {
            Clock test0 = new Clock();
            Assert.AreEqual(0, test0.CalcDegree(12, 0));
        }

        [TestMethod]
        public void CalcDegree_Is90Deg_90()
        {
            Clock test90 = new Clock();
            Assert.AreEqual(90, test90.CalcDegree(3, 0));
        }

        [TestMethod]
        public void CalcDegree_Is90Deg_180()
        {
            Clock test180 = new Clock();
            Assert.AreEqual(180, test180.CalcDegree(6, 0));
        }

        [TestMethod]
        public void CalcDegree_IsAlso90Deg_90()
        {
            Clock testAlso90= new Clock();
            Assert.AreEqual(90, testAlso90.CalcDegree(9, 0));
        }
    }
}