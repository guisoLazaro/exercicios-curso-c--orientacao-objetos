using System;
using System.Globalization;

namespace ExercicioTres {
    internal class Program {
        static void Main(string[] args) {
            Aluno aluno = new Aluno();
            CultureInfo ci = CultureInfo.InvariantCulture;
            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do Aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), ci);
            aluno.Nota2 = double.Parse(Console.ReadLine(), ci);
            aluno.Nota3 = double.Parse(Console.ReadLine(), ci);
            Console.WriteLine("Nota Final = " + aluno);
            aluno.Situacao();

        }
    }
}