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
        [Test ()]
        public void testObtenRFC1(){
            Assert.AreEqual("GOMC920803XX0", rfc.obtenRFC("GONZALEZ", "MOREIRA","CRISTINA", "03 de agosto de 1992"));

        }
       
    }
}
