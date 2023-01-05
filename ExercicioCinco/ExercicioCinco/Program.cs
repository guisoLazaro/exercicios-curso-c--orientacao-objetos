using System;
using System.Globalization;

namespace ExercicioCinco {
    internal class Program {
        static void Main(string[] args) {
            
            CultureInfo ci = CultureInfo.InvariantCulture;

            int numeroPecaUm, numeroPecaDois, codigoPecaUm, codigoPecaDois;
            double valorPecaUm, valorPecaDois, valorPagar;

            Console.WriteLine("Código, número e valor da peça um: ");
            codigoPecaUm = int.Parse(Console.ReadLine());
            numeroPecaUm = int.Parse(Console.ReadLine());
            valorPecaUm = double.Parse(Console.ReadLine(), ci);
            Console.WriteLine("Código, número e valor da peça dois: ");
            codigoPecaDois = int.Parse(Console.ReadLine());
            numeroPecaDois = int.Parse(Console.ReadLine());
            valorPecaDois = double.Parse(Console.ReadLine(), ci);
            valorPagar = (numeroPecaUm * valorPecaUm) + (numeroPecaDois * valorPecaDois);
            Console.WriteLine("Valor a pagar = R$ " + valorPagar.ToString("F2", ci));
        }
    }
}