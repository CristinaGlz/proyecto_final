using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RFC
{
    [TestClass]
    public class TestRFC
    {
        ObtenRFC rfc = new ObtenRFC();
        [TestMethod]
        public void testObtenRFC(){
            Assert.AreEqual("BECA700205XX0", rfc.obtenRFC("BERNAL", "CAMPOS", "ANGEL", "05 de febrero de 1970"));

        }
       
    }
}
