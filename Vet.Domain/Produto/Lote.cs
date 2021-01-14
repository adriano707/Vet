using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet.Domain.Produto
{
    public class Lote
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public DateTimeOffset DataFabricacao { get; private set; }
        public DateTimeOffset DataValidade { get; private set; }
        public int Quantidade { get; private set; }

        public Lote(string nome, DateTimeOffset dataFabricacao, DateTimeOffset dataValidade, int quantidade)
        {
            Id = Guid.NewGuid();
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            DataFabricacao = dataFabricacao;
            DataValidade = dataValidade;
            Quantidade = quantidade;
        }
    }
}
