using System;

namespace ExercicioCinco {
    internal class Program {
        static void Main(string[] args) {
            int n, fatorial = 1;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=  n; i++) {
                fatorial = fatorial * i;
            }
            Console.WriteLine(fatorial);
        }
    }
}