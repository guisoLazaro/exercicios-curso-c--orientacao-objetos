using System.Globalization;
namespace FuncionarioAumento
{
    public class Funcionario
    {
        public int _id { get; set; }
        public string _nome { get; set; }
        public double _salario { get; set; }

        public Funcionario(int id, string nome, double salario)
        {
            this._id = id;
            this._nome = nome;
            this._salario = salario;
        }

        public void aumentoSalario(double porcentagem)
        {
            _salario = _salario + (_salario * porcentagem) / 100;
        }

        public override string ToString()
        {
            return $"{_id}, {_nome}, " + _salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}