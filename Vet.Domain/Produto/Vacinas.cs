using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet.Domain.Produto
{
    public class Vacinas
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }

        public Vacinas() { }

        public Vacinas(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome ?? throw new ArgumentNullException(nameof(nome)); 
        }
    }
}
