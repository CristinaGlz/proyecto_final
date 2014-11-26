using System;

namespace proyectofinal
{
	public class SalarioBaseCotizacion {
		int prima;
		public int calculoPrima(int anios){
			switch (anios) {
			case 1:
				prima = 6;
				break;
			case 2:
				prima= 8;
				break;

			case 3:
				prima= 10;
				break;
			case 4:
				prima= 12;
				break;
			}
			return prima;

		}

		public double calculo(double salario,double vacas,double aginaldo, double prima)
		{
			double a =((aginaldo * salario) / 365);
			double p = ((vacas * salario * prima) / 365);
		
			return Math.Round((a + p + salario));
		}
	}
}

