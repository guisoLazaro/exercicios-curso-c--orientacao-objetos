using System;
using System.Globalization;

namespace ExercicioCingo {
    internal class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;
            int codigoItem, quantidadeItem;
            double valor = 0.0;
            string[] vet = Console.ReadLine().Split(' ');
            codigoItem = int.Parse(vet[0]);
            quantidadeItem = int.Parse(vet[1]);
            switch (codigoItem) {
                case 1:
                    valor = quantidadeItem * 4.00;
                    break;
                case 2:
                    valor = quantidadeItem * 4.50;
                    break;
                case 3:
                    valor = quantidadeItem * 5.00;
                    break;
                case 4:
                    valor = quantidadeItem * 2.00;
                    break;
                case 5:
                    valor = quantidadeItem * 1.50;
                    break;
            }
            Console.WriteLine($"Total: R${valor:F2}");
        }
    }
}