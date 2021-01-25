using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vet.Dtos.Financeiro
{
    public class ProcedimentoDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
    }
}
