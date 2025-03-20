using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnPoint
{
    public class Usuario
    {

        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }

        public Usuario(string nome, string email, string senha)
        {

            if (string.IsNullOrEmpty(nome))
            {
                throw new Exception("Nome é obrigatório!");
            }

            if (string.IsNullOrEmpty(email))
            {
                throw new Exception("Email é obrigatório!");
            }

            if (string.IsNullOrEmpty(senha))
            {
                throw new Exception("Senha é obrigatório!");
            }

            Nome = nome;
            Email = email;
            Senha = senha;
        }
    }
}
