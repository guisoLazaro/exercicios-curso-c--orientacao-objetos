using System;
namespace HospedagemHotel
{
        public class Estudante
        {
            public string Nome { get; set; }
            public string Email { get; set; }

            public Estudante(string nome, string email)
            {
                    this.Nome = nome;
                    this.Email = email;
            }
            public string Listar()
            {
                return Nome + ", " + Email;
            }
        }
}