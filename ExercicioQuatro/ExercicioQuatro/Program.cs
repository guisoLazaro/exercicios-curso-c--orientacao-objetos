using System;
using System.Globalization;

namespace ExercicioQuatro {
    internal class Program {
        static void Main(string[] args) {
            int numeroFuncionario, horasTrabalhadas;
            double valorHoraTrabalhada, salario;

            CultureInfo ci = CultureInfo.InvariantCulture;

            Console.WriteLine("Digite seu numero: ");
            numeroFuncionario = int.Parse(Console.ReadLine(), ci);
            Console.WriteLine("Digite a quantidade de horas trabalhadas: ");
            horasTrabalhadas = int.Parse(Console.ReadLine(), ci);
            Console.WriteLine("Digite o valor por hora trabalhada: ");
            valorHoraTrabalhada = double.Parse(Console.ReadLine(), ci);
            salario = valorHoraTrabalhada * horasTrabalhadas;
            Console.WriteLine("Numero = " + numeroFuncionario.ToString());
            Console.WriteLine("Salário = U$ " + salario.ToString("F2", ci));


        }
    }
}