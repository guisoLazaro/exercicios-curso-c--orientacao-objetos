using System.Globalization;
using System;

namespace ExerciciosSessaoTres {
    internal class ExercicioDoisBase {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;
            double area, raio;
            double p = 3.14159;
            Console.WriteLine("Digite o raio: ");
            raio = double.Parse(Console.ReadLine(), ci);
            area = p * (raio * raio);
            Console.WriteLine("Area = " + area.ToString("F4", ci));
        }
    }
}