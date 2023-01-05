using System;
using System.Globalization;

namespace ExercicioDois {
    internal class Program {
        static void Main(string[] args) {
            
            CultureInfo ci = CultureInfo.InvariantCulture;

            Funcionario func1, func2;
            double media;

            func1 = new Funcionario();
            func2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario:");
            Console.Write("Nome: ");
            func1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            func1.Salario = double.Parse(Console.ReadLine(), ci);
            Console.WriteLine("Dados do segundo funcionario:");
            Console.Write("Nome: ");
            func2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            func2.Salario = double.Parse(Console.ReadLine(), ci);
            media = (func1.Salario + func2.Salario) / 2;
            Console.WriteLine("Salário médio = " + media.ToString("F2", ci));



        }
    }
}