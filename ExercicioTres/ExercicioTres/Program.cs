using System;

namespace ExercicioTres {
    internal class ExercicioTres {
        static void Main(string[] args) {
            int n1, n2, n3, n4;
            int diferenca;
            Console.WriteLine("Digite 4 numeros: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());
            diferenca = (n1 * n2 - n3 * n4);
            Console.WriteLine("Diferença = " + diferenca.ToString());
        }
    }
}