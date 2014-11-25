using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prestaciones
{
    [TestClass]
   
        public class TestPrest
    {
        CalculaPrestOrd calOrd = new CalculaPrestOrd();
        CalculaPrestExt calExt = new CalculaPrestExt();
        [TestMethod]
        public void TestSalarioSemanal()
        {
            Assert.AreEqual(700, calOrd.SalarioSemanal(100));
        }
        [TestMethod]
        public void TestSalarioQuincenal()
        {
            Assert.AreEqual(1500, calOrd.SalarioQuincenal(100));
        }
        [TestMethod]
        public void TestSalarioMensual()
        {
            Assert.AreEqual(3000, calOrd.SalarioMensual(100));
        }
        [TestMethod]
        public void TestPrimaVac()
        {
            Assert.AreEqual(150, calOrd.Primavacacional(100));
        }
        [TestMethod]
        public void TestAguinaldo()
        {
            Assert.AreEqual(1500, calOrd.Aguinaldo(1,100));
        }
        [TestMethod]
        public void TestTiempoExtra()
        {
            Assert.AreEqual(12.5, calExt.tiempoExtraordinario(9, 100));
        }
        [TestMethod]
        public void TestTiempoExtra1()
        {
            Assert.AreEqual(258.5, calExt.tiempoExtraordinario(10, 100));
        }
    }
}
