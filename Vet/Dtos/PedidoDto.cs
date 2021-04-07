using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Domain.Pessoa;

namespace Vet.Dtos.Financeiro
{
    public class PedidoDto
    {
        public Guid Id { get; set; }
        public DateTimeOffset Data { get; set; }
        public PessoaDto Cleinte { get; set; }
        public string Numero { get; set; }
        public string Observacoes { get; set; }
        public double Total { get; set; }
        public string Usuario { get; set; }
    }
}
