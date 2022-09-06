using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEstatico
{
    class ConversorDeMoeda
    {

        public static double Conversao(double cotacao, double quantidade)
        {
            return cotacao * quantidade * 1.06;
        }


    }
}
