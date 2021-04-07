using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Api.Dtos;
using Vet.Data;
using Vet.Domain.Endereco;
using Vet.Dtos;

namespace Vet.Api.Controllers
{
    [ApiController]
    [Route("enderecos")]
    public class EnderecoController : ControllerBase
    {

        public EnderecoController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        private readonly DataContext _dataContext;

        [HttpGet]
        public async Task<IActionResult> ObterEndereco()
        {
            var endereco = _dataContext.Endereco.ToList();
            return Ok(endereco);
        }

        [HttpPost]
        public async Task<IActionResult> CriarEndereco([FromBody] EnderecoDto enderecoDto)
        {
            var estado = _dataContext.Estado.FirstOrDefault(a => a.Id == enderecoDto.Estado.Id);
            var cidade = _dataContext.Cidade.FirstOrDefault(a => a.Id == enderecoDto.Cidade.Id);
            var bairro = _dataContext.Bairro.FirstOrDefault(a => a.Id == enderecoDto.Bairro.Id);

            Endereco endereco = new Endereco(bairro,
                cidade,
                estado,
                enderecoDto.CEP, enderecoDto.Numero, enderecoDto.Rua, enderecoDto.Complemento);
            _dataContext.Add(endereco);
            await _dataContext.SaveChangesAsync();
            return Ok(endereco);
        }
        
        [HttpGet]
        [Route("estados")]
        public async Task<IActionResult> ObterEstado()
        {
            var estados = _dataContext.Estado.ToList();
            return Ok(estados);
        }

        [HttpGet]
        [Route("estados")]
        public async Task<IActionResult> ObterEstado([FromBody] EstadoDto estadoDto)
        {
            Estado estados = new Estado(estadoDto.Nome, estadoDto.Sigla);
            _dataContext.Add(estados);
            await _dataContext.SaveChangesAsync();
            return Ok(estados);
        }

        [HttpGet]
        [Route("Cidades")]
        public async Task<IActionResult> ObterCidade()
        {
            var cidades = _dataContext.Cidade.ToList();
            return Ok(cidades);
        }

        [HttpPost]
        public async Task<IActionResult> CriarCidade([FromBody] CidadeDto cidadeDto)
        {
            Cidade cidades = new Cidade(cidadeDto.Nome);
            _dataContext.Add(cidades);
            await _dataContext.SaveChangesAsync();
            return Ok(cidades);
        }

        [HttpGet]
        [Route("bairros")]
        public async Task<IActionResult> ObterBairro()
        {
            var bairros = _dataContext.Bairro.ToList();
            return Ok(bairros);
        }

        [HttpPost]
        public async Task<IActionResult> CriarBairro([FromBody] BairroDto bairroDto)
        {
            Bairro bairros = new Bairro(bairroDto.Nome);
            _dataContext.Add(bairros);
            await _dataContext.SaveChangesAsync();
            return Ok(bairros);
        }

    }
}
