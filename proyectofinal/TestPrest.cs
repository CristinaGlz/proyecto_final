using System;
using NUnit.Framework;
namespace proyectofinal
{

   	[TestFixture ()]
   
        public class TestPrest
    {
        [Test()]
        public void TestSalarioSemanal()
        {
		CalculaPrestOrd calOrd = new CalculaPrestOrd();
            Assert.AreEqual(700, calOrd.SalarioSemanal(100));
        }
        [Test()]
        public void TestSalarioQuincenal()
        {
		CalculaPrestOrd calOrd = new CalculaPrestOrd();
            Assert.AreEqual(1500, calOrd.SalarioQuincenal(100));
        }
        [Test()]
        public void TestSalarioMensual()
        {
		CalculaPrestOrd calOrd = new CalculaPrestOrd();
            Assert.AreEqual(3000, calOrd.SalarioMensual(100));
        }
        [Test()]
        public void TestPrimaVac()
        {
		CalculaPrestOrd calOrd = new CalculaPrestOrd();
            Assert.AreEqual(150, calOrd.Primavacacional(100));
        }
        [Test()]
        public void TestAguinaldo()
        {
		CalculaPrestOrd calOrd = new CalculaPrestOrd();
            Assert.AreEqual(1500, calOrd.Aguinaldo(1,100));
        }
        [Test()]
        public void TestTiempoExtra()
        {
		
        CalculaPrestExt calExt = new CalculaPrestExt();
            Assert.AreEqual(12.0, calExt.tiempoExtraordinario(9, 100));
        }
        [Test()]
        public void TestTiempoExtra1()
        {
		
        CalculaPrestExt calExt = new CalculaPrestExt();
            Assert.AreEqual(252.0, calExt.tiempoExtraordinario(10, 100));
        }
    }
}
