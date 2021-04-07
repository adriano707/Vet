using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vet.Data;
using Vet.Domain.Consulta;
using Vet.Dtos;
using Vet.Dtos.Consulta;

namespace Vet.Api.Controllers
{
    [ApiController]
    [Route("consultas")]
    public class ConsultaController : ControllerBase
    {
        public ConsultaController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        private readonly DataContext _dataContext;

        [HttpGet]
        public async Task<IActionResult> ObterConsulta()
        {
            var consulta = _dataContext.Consulta.ToList();
            return Ok(consulta);
        }

        [HttpPost]
        public async Task<IActionResult> CriarConsulta([FromBody] ConsultaDto consultaDto)
        {

            var pessoaCliente = _dataContext.Pessoa.FirstOrDefault(a => a.Id == consultaDto.Cliente.Id);
            var pessoaVeterinario = _dataContext.Pessoa.FirstOrDefault(a => a.Id == consultaDto.Veterinario.Id);
            var animalPaciente = _dataContext.Animal.FirstOrDefault(a => a.Id == consultaDto.Paciente.Id);

            Consulta consulta = new Consulta(consultaDto.DataInicio,
            pessoaCliente,
            pessoaVeterinario,
            consultaDto.Peso,
            consultaDto.Temperatura,
            consultaDto.QueixaPrincipal,
            consultaDto.Procedimento,
            consultaDto.Total,
            consultaDto.Unitario,
            consultaDto.Quantidade,
            consultaDto.Situacao,
            animalPaciente,
            consultaDto.Observacoes,
            consultaDto.DataLimiteRetorno,
            consultaDto.DataEncerramento,
            consultaDto.Status
            );
        }
    }
}
