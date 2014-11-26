
namespace proyectofinal
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    public class CalculaPrestOrd
    {
        public double SalarioSemanal(double s)
        {
            return s * 7;
        }
        public float SalarioQuincenal(float s)
        {
            return s * 15;
        }
        public float SalarioMensual(float s)
        {
            return s * 30;
        }
        public double Aguinaldo(int anios, double s)
        {
            if (anios >= 1)
                return s * 15;
            else
                return (0.0);
        }
        public double Primavacacional(double s)
        {
            return (s * 6) * .25;
        }
    }
}
