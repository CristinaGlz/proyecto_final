using System;
using NUnit.Framework;

namespace proyectofinal
{
   [TestFixture ()]
    public class TestCURP
    {
        ObtenCURP curp = new ObtenCURP();
         [Test()]
        public void TestObtenCURP()
        {
            Assert.AreEqual("MEZJ910514HZSDRR00", curp.creaCURP("MEDINA", "ZARAGOZA","JORGE","1991,05,14","H","Zacatecas"));
        }
		 [Test()]
        public void TestObtenCURP1()
        {
            Assert.AreEqual("GOMC920803MZSNRR00", curp.creaCURP("GONZALEZ", "MOREIRA","CRISTINA","1992,08,03","M","Zacatecas"));
        }
		 [Test()]
        public void TestObtenCURP2()
        {
            Assert.AreEqual("AAPR630321HDFLRC00", curp.creaCURP("ALAMAN", "PEREZ","RICARDO","1963,03,21","H","Distrito Federal"));
        }
    }
}

  
      
	
