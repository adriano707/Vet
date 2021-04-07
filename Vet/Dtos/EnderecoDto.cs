using System;
using Vet.Dtos;

namespace Vet.Api.Dtos
{
    public class EnderecoDto
    {
        public Guid Id { get; set; }
        public BairroDto Bairro { get; set; }
        public CidadeDto Cidade { get; set; }
        public EstadoDto Estado { get; set; }
        public string CEP { get; set; }
        public string Numero { get; set; }
        public string Rua { get; set; }
        public string Complemento { get; set; }
    }
}