using System;

namespace ExercicioUm {
    internal class Program {
        static void Main(string[] args) {

            int num;
            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) {
                Console.WriteLine("PAR");
            }
            else {
                Console.WriteLine("IMPAR");
            }
        }
    }
}