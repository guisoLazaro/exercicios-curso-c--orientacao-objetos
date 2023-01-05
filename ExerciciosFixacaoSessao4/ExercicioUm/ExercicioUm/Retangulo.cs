using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioUm {
    internal class Retangulo {

        public double Largura;
        public double Altura;

        public double Area() {

            double area = Largura * Altura;
            return area;
        }

        public double Perimetro() {
            return 2 * (Largura + Altura);
        }

        public double Diagonal() {
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }
    }
}
