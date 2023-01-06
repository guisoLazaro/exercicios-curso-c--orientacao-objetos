using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExMembrosEstaticos {
    internal class ConversorDeMoeda {

        public static double Converter(double conversor, double quantidade) {
            double valor = conversor * quantidade;
            double valorImposto = valor + (valor * 6.0) / 100;
            return valorImposto;
        }

    }
}
