using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet.Domain.Produto
{
    public class Produto
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public Tipo Tipo { get; set; }

        public Produto() { }

        public Produto(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
        }

    }
}
