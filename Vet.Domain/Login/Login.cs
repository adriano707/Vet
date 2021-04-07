using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet.Domain.Login
{
    public class Login
    {
        public Guid Id { get; private set; }
        public string Usuario { get; private set; }
        public string Senha { get; private set; }

        public Login() { }

        public Login(string usuario, string senha)
        {
            Id = Guid.NewGuid();
            Usuario = usuario ?? throw new ArgumentNullException(nameof(usuario));
            Senha = senha ?? throw new ArgumentNullException(nameof(senha));
        }
    }
}
