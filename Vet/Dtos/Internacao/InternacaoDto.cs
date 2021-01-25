using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vet.Dtos.Internacao
{
    public class InternacaoDto
    {
        public Guid Id { get; set; }
        public DateTimeOffset Data { get; set; }
        public DateTimeOffset PrevisaoAlta { get; set; }
        public string Animal { get; set; }
        public string Observacoes { get; set; }
    }
}
