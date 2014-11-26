using System;

namespace proyectofinal
{
	public class Aguinaldo
	{

		public double calculoAguialdo(double diasA,double anio,double diaslabo,double saldia){
			double di =Math.Round((diasA/anio),3);
			double d=Math.Round((diaslabo*di),2);
			double p=d*saldia;
			return Math.Round ((p), 2);
		}

	}
}

