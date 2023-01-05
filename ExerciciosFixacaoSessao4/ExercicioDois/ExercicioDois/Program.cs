using System;
using System.Globalization;


namespace ExercicioDois {
    internal class Program {
        static void Main(string[] args) {
            
            CultureInfo ci = CultureInfo.InvariantCulture;

            Funcionario func = new Funcionario();
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), ci);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), ci);
            Console.WriteLine("Funcionario: " + func );
            Console.WriteLine("Digite a porcentagem para aumentar o salario: ");
            double aumento = double.Parse(Console.ReadLine(), ci);
            func.AumentarSalario(aumento);
            Console.WriteLine("Dados Atualizados: " + func);
            
        }
    }
}