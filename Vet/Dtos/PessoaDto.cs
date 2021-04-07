using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Api.Dtos;

namespace Vet.Dtos
{
    public class PessoaDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public List<EnderecoDto> Enderecos { get; set; }
    }
}
