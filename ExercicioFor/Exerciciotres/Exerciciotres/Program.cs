using System;
using System.Globalization;

namespace Exerciciotres {
    internal class Program {
        static void Main(string[] args) {
            
            CultureInfo ci = CultureInfo.InvariantCulture;
            
            int n, i;
            double media, n1, n2, n3;
            n = int.Parse(Console.ReadLine());
            for(i = 0; i < n; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                n1 = double.Parse(vet[0], ci);
                n2 = double.Parse(vet[1], ci);
                n3 = double.Parse(vet[2], ci);
                media = ((n1 * 2.0) + (n2 * 3.0) + (n3 * 5.0)) / (2.0 + 3.0 + 5.0);
                Console.WriteLine(media.ToString("F1", ci));
            }
        
        }

    }
}