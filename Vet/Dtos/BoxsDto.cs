using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vet.Dtos.PessoaDtos
{
    public class BoxsDto
    {
        public Guid Id { get; set; }
        public string Identificacao { get; set; }
        public string Observacao { get; set; }
    }
}
