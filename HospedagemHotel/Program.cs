﻿using System;
using HospedagemHotel;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Quantos estudantes vão alugar os quartos? ");
        int n = int.Parse(Console.ReadLine());
        Estudante[] vect = new Estudante[10];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Aluguel {i + 1}: ");
            Console.Write($"Nome: ");
            string nome = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Quarto: ");
            int quarto = int.Parse(Console.ReadLine());
            vect[quarto] = new Estudante(nome, email);

        }
        Console.WriteLine("Quartos ocupados:");
        for (int i = 0; i < 10; i++)
        {
            if(vect[i] !=  null)
            {
                Console.WriteLine($"{i}: {vect[i].Listar()}");
            }
        }
    }
}
