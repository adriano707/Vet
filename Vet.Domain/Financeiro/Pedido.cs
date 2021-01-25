using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet.Domain.Financeiro
{
    public class Pedido
    {
        public Guid Id { get; private set; }
        public DateTimeOffset Data { get; private set; }
        public Pessoa.Cliente Cleinte { get; set; }
        public string Numero { get; private set; }
        public string Observacoes { get; private set; }
        public double Total { get; private set;  }
        public string Usuario { get; private set; }

        public Pedido(Pessoa.Cliente cliente, string numero, string observacoes, double total, string usuario)
        {
            Id = Guid.NewGuid();
            Data = DateTimeOffset.Now;
            Cleinte = cliente ?? throw new ArgumentNullException(nameof(cliente));
            Numero = numero ?? throw new ArgumentNullException(nameof(numero));
            Observacoes = observacoes;
            Total = total;
            Usuario = usuario;
        }
    }
}
