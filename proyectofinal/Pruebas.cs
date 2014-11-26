using NUnit.Framework;
using System;

namespace proyectofinal
{

	[TestFixture ()]
	public class Pruebas
	{

				
		[Test ()]
		public  void TestCase ()
		{
			Ingreso ing = new Ingreso ();
			Assert.AreEqual(2018.7,ing.exentos(100,30,30,"A"));
		}
		[Test ()]
		public  void TestCase1 ()
		{
			Ingreso ing = new Ingreso ();
			Assert.AreEqual(1009.35,ing.exentos(100,30,15,"A"));
		}
		[Test ()]
		public  void TestCase2()
		{
			SalarioBaseCotizacion sbc = new SalarioBaseCotizacion ();
			Assert.AreEqual (209.0, sbc.calculo (200.00,sbc.calculoPrima(1),15, 0.25));
		}
		[Test ()]
		public  void Prima()
		{
			SalarioBaseCotizacion sbc = new SalarioBaseCotizacion ();
			Assert.AreEqual (12, sbc.calculoPrima(4));
		}
		[Test ()]
		public  void Aguinaldo()
		{
			Aguinaldo agui = new Aguinaldo ();
			Assert.AreEqual (1051.65, agui.calculoAguialdo(15,365,270,95));
		}


	}
}

