using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Data;
using Vet.Domain.Pessoa;
using Vet.Dtos;

namespace Vet.Controllers
{
    [ApiController]
    [Route("Pessoas")]
    public class PessoaController : ControllerBase
    {
        public PessoaController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        private readonly DataContext _dataContext;

        [HttpGet]
        public async Task<IActionResult> ObterTodasPessoas()
        {
            var pessoas = _dataContext.Pessoa.ToList();
            return Ok(pessoas);
        }

        [HttpGet]
        [Route("{id}")]
        public Pessoa ObterPessoaPeloId([FromRoute] Guid id)
        {
            return null;
        }


        [HttpPost]
        public async Task<IActionResult> CriarPessoa([FromBody] PessoaDto pessoaDto)
        {
            Pessoa pessoa = new Pessoa(pessoaDto.Nome);
            _dataContext.Add(pessoa);
            await _dataContext.SaveChangesAsync();
            return Ok();
        }
    }
}
