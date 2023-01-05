using System;
using System.Globalization;

namespace ExercicioQuatro {
    internal class Program {
        static void Main(string[] args) {
            
            CultureInfo ci = CultureInfo.InvariantCulture;
            
            int n;
            double div;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                double n1 = double.Parse(vet[0]);
                double n2 = double.Parse(vet[1]);
                if (n2 == 0) {
                    Console.WriteLine("Divisão impossivel");
                }
                else {
                    div = n1 / n2;
                    Console.WriteLine(div.ToString("F1", ci));
                }
            }


        }
    }
}