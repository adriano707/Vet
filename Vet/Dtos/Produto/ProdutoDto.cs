using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Domain.Produto;

namespace Vet.Dtos.Produto
{
    public class ProdutoDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Tipo Tipo { get; set; }
    }
}
