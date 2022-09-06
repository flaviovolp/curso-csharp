using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembroEstatico1
{
    class Calculadora
    {
        public static double Pi = 3.14;

        public static double Circunferencia(double r)
        {

            return 2.0 * Math.PI * r;
        }

        public static double Volume(double r)
        {

            return 4.0 / 3 * Math.PI * Math.Pow(r, 3.0);
        }







    }
}
