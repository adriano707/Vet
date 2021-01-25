using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet.Domain.Animal
{
    public class Animal
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }

        public Animal(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
        }

    }
}
