using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet.Domain.Pessoa
{
    class Boxs
    {
        public Guid Id { get; private set; }
        public string  Identificacao { get; private set; }
        public string Observacao { get; private set; }

        public Boxs(string identificacao, string observacao)
        {
            Id = Guid.NewGuid();
            Identificacao = identificacao;
            Observacao = observacao;
        }
    }
}
