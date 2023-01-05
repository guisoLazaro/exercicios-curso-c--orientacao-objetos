using System;
using System.Globalization;


namespace ExercicioTres {
    internal class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int num1, num2;
            string[] vet = Console.ReadLine().Split(' ');
            num1 = int.Parse(vet[0]);
            num2 = int.Parse(vet[1]);
            if(num1 % num2 == 0 || num2 % num1 == 0) {
                Console.WriteLine("São multiplos");
            }
            else {
                Console.WriteLine("Não são Multiplos");
            }
        }
    }
}
        