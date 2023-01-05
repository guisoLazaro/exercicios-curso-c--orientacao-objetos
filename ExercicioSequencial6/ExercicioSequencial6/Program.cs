using System;
using System.Globalization;

namespace ExercicioSequencial6 {
    internal class Program {
        static void Main(string[] args) {
           
            CultureInfo ci = CultureInfo.InvariantCulture;

            double areaTrianguloRetangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo, a, b, c;

            string[] vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0], ci);
            b = double.Parse(vet[1], ci);
            c = double.Parse(vet[2], ci);
            areaTrianguloRetangulo = (a * c) / 2;
            areaCirculo = 3.14159 * (c * c);
            areaTrapezio = ((a + b) / 2) * c;
            areaQuadrado = b * b;
            areaRetangulo = a * b;
            Console.WriteLine($"Triângulo: {areaTrianguloRetangulo.ToString("F3", ci)}");
            Console.WriteLine($"Circulo: {areaCirculo.ToString("F3", ci)}");
            Console.WriteLine($"Trapézio: {areaTrapezio.ToString("F3", ci)}");
            Console.WriteLine($"Quadrado: {areaQuadrado.ToString("F3", ci)}");
            Console.WriteLine($"Retângulo: {areaRetangulo.ToString("F3", ci)}");

        }
    }
}