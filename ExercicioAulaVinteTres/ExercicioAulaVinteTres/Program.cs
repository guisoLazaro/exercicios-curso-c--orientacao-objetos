using System;
using System.Globalization;

namespace ExercicioAulaVinteTres {
    internal class Program {
        static void Main(string[] args) {
            
            CultureInfo ci = CultureInfo.InvariantCulture;

            string nome, ultimoNome;
            int quarto, idade;
            double preco, altura;

            Console.WriteLine("Entre com seu nome completo: ");
            nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            quarto = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            preco = double.Parse(Console.ReadLine(), ci);
            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha): ");
            string[] vet = Console.ReadLine().Split(' ');
            ultimoNome = vet[0];
            idade = int.Parse(vet[1]);
            altura = double.Parse(vet[2], ci);
            Console.WriteLine($"{nome}");
            Console.WriteLine($"{quarto}");
            Console.WriteLine($"{preco.ToString("F2", ci)}");
            Console.WriteLine($"{ultimoNome}");
            Console.WriteLine($"{idade}");
            Console.WriteLine($"{altura.ToString("F2", ci)}");

            
        }
    }
}