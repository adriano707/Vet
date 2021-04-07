using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet.Domain.Endereco
{
    public class Estado
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Sigla { get; private set; }

        public Estado() { }

        public Estado(string nome, string sigla)
        {
            Id = Guid.NewGuid();
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Sigla = sigla;
        }
    }
}
