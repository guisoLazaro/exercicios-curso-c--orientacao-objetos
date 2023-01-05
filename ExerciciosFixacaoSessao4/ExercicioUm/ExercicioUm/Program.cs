using System;
using System.Globalization;

namespace ExercicioUm {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.InvariantCulture;

            Retangulo ret = new Retangulo();
            Console.WriteLine("Digite a largura e altura do retangulo: ");
            ret.Altura = double.Parse(Console.ReadLine(), ci);
            ret.Largura = double.Parse(Console.ReadLine(), ci);

            Console.WriteLine("Area = " + ret.Area().ToString("F2", ci));
            Console.WriteLine("Perimetro = " + ret.Perimetro().ToString("F2", ci));
            Console.WriteLine("Diagonal = " + ret.Diagonal().ToString("F2", ci));


            
            
        }
    }
}