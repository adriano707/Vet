using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vet.Domain.Pessoa;

namespace Vet.Domain.Financeiro
{
    public class Pedido
    {
        private List<Procedimento> _procedimentos;
        public Guid Id { get; private set; }
        public DateTimeOffset Data { get; private set; }
        public Cliente Cliente { get; set; }
        public string Numero { get; private set; }
        public string Observacoes { get; private set; }
        public double Total { get; private set;  }
        public string Usuario { get; private set; }
        public IReadOnlyCollection<Procedimento> Procedimento => _procedimentos;

        public Pedido() { }

        public Pedido(Pessoa.Cliente cliente, string numero, string observacoes, double total, string usuario)
        {
            Id = Guid.NewGuid();
            Data = DateTimeOffset.Now;
            Cliente = cliente ?? throw new ArgumentNullException(nameof(cliente));
            Numero = numero ?? throw new ArgumentNullException(nameof(numero));
            Observacoes = observacoes ?? throw new ArgumentException(nameof(observacoes));
            Total = total;
            Usuario = usuario ?? throw new ArgumentException(nameof(usuario));
        }
    }
}
