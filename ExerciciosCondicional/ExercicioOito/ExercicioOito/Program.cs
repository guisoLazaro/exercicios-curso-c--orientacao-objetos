using System;
using System.Globalization;

namespace ExercicioOito {
    internal class Program {
        static void Main(string[] args) {
           
            CultureInfo ci = CultureInfo.InvariantCulture;

            double salario, imposto = 0.0, diferenca = 0.0;
            salario = double.Parse(Console.ReadLine(), ci);
            if (salario <= 2000.00) {
                Console.WriteLine("Isento");
            }
            else if (salario > 2000.00 && salario <= 3000.00) {
                imposto = (salario - 2000) * 8 / 100;
            }
            else if (salario > 3000.00 && salario <= 4500.00) {
                diferenca = (salario - 2000) - 1000;
                imposto = ((1000 * 8) / 100) + (diferenca * 18) / 100;
            }
            else {
                imposto = (salario - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
            }
            Console.WriteLine($"R$ {imposto:F2}");
            
        }
    }
}