using System;


namespace ExercicioTres {
    internal class Program {
        static void Main(string[] args) {
            int cod, somaAlcool = 0, somaGasolina = 0, SomaDiesel = 0;
            cod = int.Parse(Console.ReadLine());
            while (cod != 4) {
                if (cod == 1) {
                    somaAlcool++;
                }
                else if (cod == 2) {
                    somaGasolina++;
                }
                else if (cod == 3) {
                    SomaDiesel++;
                }
                cod = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Muito Obrigado");
            Console.WriteLine($"Alcool: {somaAlcool}");
            Console.WriteLine($"Gasolina: {somaGasolina}");
            Console.WriteLine($"Gasolina: {SomaDiesel}");
        }
    }
}

