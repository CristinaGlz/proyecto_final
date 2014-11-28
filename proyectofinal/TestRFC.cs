using System;
using NUnit.Framework;

namespace proyectofinal
{
  [TestFixture ()]
    public class TestRFC
    {
        ObtenRFC rfc = new ObtenRFC();
        [Test ()]
        public void testObtenRFC(){
            Assert.AreEqual("BECA700205XX0", rfc.obtenRFC("BERNAL", "CAMPOS", "ANGEL", "05 de febrero de 1970"));

        }
       
    }
}
