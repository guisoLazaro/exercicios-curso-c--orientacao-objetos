using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ContaBancaria {
    internal class Conta {

        private int _numero;
        private double _saldo;
        public string Nome;


        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        public void Depositar(double quantia) 
        {
            _saldo = quantia;
        }

        public void Sacar(double quantia) 
        {
            _saldo = _saldo - quantia - 5.00;
        }

        public void ExibirDadosAtualizados()
        {
            Console.WriteLine($"Conta {_numero} Titular: {Nome}, Saldo: R${_saldo.ToString("F2", CultureInfo.InvariantCulture)}");
        }


    }
}
