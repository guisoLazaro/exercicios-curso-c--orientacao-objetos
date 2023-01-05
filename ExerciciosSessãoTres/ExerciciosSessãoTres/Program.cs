using System;
using System.Globalization;

namespace ExerciciosSessaoTres {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.CurrentCulture; // variavel para colocar casas decimais
            int n1, n2, soma;
            Console.WriteLine("Digite o primeiro numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            n2 = int.Parse(Console.ReadLine());
            soma = n1 + n2;
            Console.WriteLine("SOMA = " + soma.ToString("F2", ci)); //impressão na tela f2 para duas casas decimais 


        }
    }
}