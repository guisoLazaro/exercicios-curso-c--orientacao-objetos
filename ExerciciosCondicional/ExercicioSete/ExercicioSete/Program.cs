using System;
using System.Globalization;

namespace ExercicioSete {
    internal class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            double num1, num2;
            string[] vet = Console.ReadLine().Split(' ');
            num1 = double.Parse(vet[0], ci);
            num2 = double.Parse(vet[1], ci);
            if (num1 > 0 && num2 < 0) {
                Console.WriteLine("Q4");
            }
            else if (num1 < 0 && num2 > 0) {
                Console.WriteLine("Q2");
            }
            else if (num1 < 0 && num2 < 0) {
                Console.WriteLine("Q3");
            }
            else if (num1 > 0 && num2 > 0) {
                Console.WriteLine("Q1");
            }
            else {
                Console.WriteLine("Origem");
            }
        }
    }
}