using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioTres {
    internal class Aluno {

        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double Soma() {

            double soma = Nota1 + Nota2 + Nota3;
            return soma;
        }

        public void Situacao() {

            if(Soma() >= 60) {
                Console.WriteLine("Aprovado");
            }
            else {
                double restante = 60 - Soma();
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltam " + restante.ToString("F2", CultureInfo.InvariantCulture) + " pontos");
            }
        }

        public override string ToString() {
            return Soma().ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}
