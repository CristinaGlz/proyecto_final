namespace proyectofinal
{
using NUnit.Framework;
using System;


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

	}
}

