using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject3
{
    [TestClass]
    public class TestCURP
    {
        ObtenCURP curp = new ObtenCURP();
        [TestMethod]
        public void TestObtenCURP()
        {
            Assert.AreEqual("MEZJ19910514HZSDRR00", curp.creaCURP("MEDINA", "ZARAGOZA","JORGE","19910514","H","Zacatecas"));
        }
    }
}
