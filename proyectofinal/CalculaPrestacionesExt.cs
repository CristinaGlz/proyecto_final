using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestaciones
{
    class CalculaPrestExt
    {
        public double tiempoExtraordinario(int horas, int s)
        {
            int sh = s/8;
            if (horas <= 9)
                return sh;
            else
            {
                int horast = horas - 9;
                double dob = (sh * 2) * 9;
                double trip = (sh * 3) * horast;

                return dob + trip;
            }
        }
    }
}
