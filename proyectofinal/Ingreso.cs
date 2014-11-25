namespace proyectofinal{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

	public class Ingreso
	{
	
		public double exentos(double dia,double tipo,double aguinaldo, String zona){
			double exe;
			double zon;
			 
				if (zona =="A")
				{
					zon=67.29;
				}else{
					zon=63.77;
				}
			exe = aguinaldo * zon;
			return Math.Round(exe,2);
		}
	}
}

