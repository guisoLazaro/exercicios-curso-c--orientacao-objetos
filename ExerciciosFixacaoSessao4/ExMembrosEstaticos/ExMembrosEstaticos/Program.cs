using System;
using System.Globalization;

namespace ExMembrosEstaticos {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Qual é a cotação do dolar: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dolares você vai comprar? ");
            double qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor a ser pago em Reais: " + ConversorDeMoeda.Converter(cotacao, qtd).ToString("F2", CultureInfo.CurrentCulture));
        }
    }
}