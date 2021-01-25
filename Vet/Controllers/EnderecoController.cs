using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Domain.Endereco;

namespace Vet.Controllers
{
    [ApiController]
    [Route("Enderecos")]
    public class EnderecoController : ControllerBase
    {
        [HttpGet]
        public List<Endereco> ObterTodos()
        {
            return new List<Endereco>();
        }
        [HttpGet]
        [Route("{id}")]
        public Endereco ObterEnderecoPeloId([FromRoute] Guid id)
        {
            return null;
        }

        [HttpGet]
        [Route("Estados")]
        public List<Estado> ObterEstado()
        {
            return new List<Estado>();
        }

        [HttpGet]
        [Route("{id}")]
        public Estado ObterEstadoPeloId([FromRoute] Guid id) {
            return null;
        }

        [HttpGet]
        [Route("Cidades")]
        public List<Cidade> ObterCidade()
        {
            return new List<Cidade>();
        }

        [HttpGet]
        [Route("Bairros")]
        public List<Bairro> ObterBairro()
        {
            return new List<Bairro>();
        }
    }
}
