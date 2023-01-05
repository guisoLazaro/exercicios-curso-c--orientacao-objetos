using System;

namespace ExercicioDois {
    internal class Program {
        static void Main(string[] args) {
            int num1, num2;
            string[] vet = Console.ReadLine().Split(' ');
            num1 = int.Parse(vet[0]);
            num2 = int.Parse(vet[1]);
            while (num1 != 0 || num2 != 0) {
                if (num1 > 0 && num2 > 0) {
                    Console.WriteLine("primeiro");
                }
                else if (num1 < 0 && num2 > 0) {
                    Console.WriteLine("segundo");
                }
                else if (num1 < 0 && num2 < 0) {
                    Console.WriteLine("terceiro");
                }
                else if (num1 > 0 && num2 < 0) {
                    Console.WriteLine("quarto");
                }
                vet = Console.ReadLine().Split(' ');
                num1 = int.Parse(vet[0]);
                num2 = int.Parse(vet[1]);
            }
        }
    }
}