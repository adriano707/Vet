using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet.Domain.Financeiro
{
    public class Procedimento
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public double Valor { get; private set; }

        public Procedimento() { }

        public Procedimento(string nome, double valor)
        {
            Id = Guid.NewGuid();
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Valor = valor;
        }
    }
}
