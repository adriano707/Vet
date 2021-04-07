using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vet.Dtos.Produto
{
    public class LoteDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTimeOffset DataFabricacao { get; set; }
        public DateTimeOffset DataValidade { get; set; }
        public int Quantidade { get; set; }
    }
}
