using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Domain.Pessoa;
using Vet.Dtos;

namespace Vet.Controllers
{
    [ApiController]
    [Route("Pessoas")]
    public class PessoaController : ControllerBase
    {
        public List<Pessoa> ObterTodasPessoas()
        {
            return new List<Pessoa>();
        }

        [HttpGet]
        [Route("Pessoa")]
        public Pessoa ObterPessoaPeloId([FromRoute] Guid id)
        {
            return null;
        }

        public Pessoa ObterPessoaPorTipo()
        {
            return null;
        }

        [HttpPost]
        public async Task<IActionResult> CriarPessoa([FromBody] PessoaDto pessoaDto)
        {
            return Ok();
        }
    }
}
