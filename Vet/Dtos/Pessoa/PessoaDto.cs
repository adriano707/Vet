using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vet.Dtos
{
    public class PessoaDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public List<EnderecosDto> Enderecos { get; set; }
    }
}
