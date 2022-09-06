using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1ListaClasse
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (2 * Largura) + (2 * Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
        }

        public override string ToString()
        {
            return "ÁREA: "
                + Area().ToString("F2", CultureInfo.InvariantCulture)
                + "\nPERÍMETRO= "
                + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + "\nDIAGONAL: "
                + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }









    }

   
}
