using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet.Domain.Animal
{
    public class Dieta
    {
        public Guid Id { get; private set; }
        public string Descricao { get; private set; }

        public Dieta() { }

        public Dieta(string descricao)
        {
            Id = Guid.NewGuid();
            Descricao = descricao ?? throw new ArgumentNullException(nameof(descricao)); 
        }
    }
   
}
