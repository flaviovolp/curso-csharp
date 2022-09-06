using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3ListaClasse
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double CalcularNotaFinal()
        {
            return Nota1 + Nota2 + Nota3;

        }

        public string AprovadoReprovado(double notaFinal)
        {
            if(notaFinal>=60)
            {
                return "APROVADO";
            }
            else
            {
                return "REPROVADO\nFALTARAM " + (60 - notaFinal).ToString("F2", CultureInfo.InvariantCulture) + " PONTOS";
            }
        }


    }
}
