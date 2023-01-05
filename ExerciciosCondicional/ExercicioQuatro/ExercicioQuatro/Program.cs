using System;
using System.Globalization;

namespace ExercicioQuatro {
    internal class Program {
        static void Main(string[] args) {

            int num1, num2, hora, horaRestante = 0;
            string[] vet = Console.ReadLine().Split(' ');
            num1 = int.Parse(vet[0]);
            num2 = int.Parse(vet[1]);
            if(num1 > num2) {
                hora = num1 - num2;
                horaRestante = 24 - hora;

            }
            else if(num1 < num2) {
                horaRestante = num2 - num1;
            }
            else if(num1 == 0 && num2 == 0 ){
                horaRestante = 24;
            }
            else if(num1 == 24 && num2 == 24) {
                horaRestante = 24;
                Console.WriteLine($"O jogo durou {horaRestante} HORA(S)");
            }
        }
    }
}