using System;

namespace ExercicioDois {
    internal class Program {
        static void Main(string[] args) {
            int n, dentro = 0, fora = 0;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
               int x = int.Parse(Console.ReadLine());
                if(x >= 10 && x <= 20) {
                    dentro++;
                }
                else {
                    fora++;
                }
            }
            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");
        }
    }
}