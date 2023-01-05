using System;

namespace ExercicioSete {
    internal class Program {
        static void Main(string[] args) {
            int n, i;
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++) {
                Console.WriteLine(i + " " + Math.Pow(i, 2) +" " + Math.Pow(i, 3));
            }
            
        }
        
    }
}