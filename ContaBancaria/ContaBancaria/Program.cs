using System;
using System.Globalization;

namespace ContaBancaria {
    internal class Program {
        static void Main(string[] args) {

            double valor;
            double saque;
            Conta c = new Conta();
            Console.Write("Entre com o número da conta: ");
            c.Numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            c.Nome = Console.ReadLine();
            string op;
            Console.Write("Haverá deposito inicial (s/n)? ");
            op = Console.ReadLine();
            if(op == "s") {

                Console.Write("Entre com o valor do deposito: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c.Depositar(valor);
            }
            c.ExibirDadosAtualizados();
            Console.Write("Entre com um valor para saque: ");
            saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Sacar(saque);
            c.ExibirDadosAtualizados();


        }
    }
}