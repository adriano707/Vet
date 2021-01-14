using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet.Domain.Pessoa
{
    public class Usuario : Pessoa
    {
        public string Email { get; private set; }
        public bool Admistrador { get; private set; }
        public string Login { get; private set; }
        public string Senha { get; private set; }

        public Usuario(string nome, string email, bool administrador, string login, string senha) : base(nome)
        {
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Admistrador = administrador;
            Login = login ?? throw new ArgumentNullException(nameof(login));
            Senha = senha ?? throw new ArgumentNullException(nameof(senha));
        }
    }
}
