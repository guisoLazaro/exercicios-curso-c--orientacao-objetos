using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExerciciosSessaoTres {
    internal class ExercicioDois {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.CurrentCulture;
            double area, raio;
            double p = 3.14159;
            Console.WriteLine("Digite o raio: ");
            raio = double.Parse(Console.ReadLine(), ci);
            area = p * (raio * raio);
            Console.WriteLine("Area = " + area.ToString("F4", ci));
        }
    }
}
