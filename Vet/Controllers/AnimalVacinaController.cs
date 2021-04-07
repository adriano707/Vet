using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Data;
using Vet.Domain.Animal;
using Vet.Dtos.Animal;

namespace Vet.Api.Controllers
{
    [ApiController]
    [Route("vacinas")]
    public class AnimalVacinaController : ControllerBase
    {
        public AnimalVacinaController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        private readonly DataContext _dataContext;

        [HttpGet]
        public async Task<IActionResult> ObterVacina()
        {
            var vacina = _dataContext.AnimalVacina.ToList();
            return Ok(vacina);
        }

        [HttpPost]
        public async Task<IActionResult> CriarVacina([FromBody] AnimalVacinaDto animalVacinaDto)
        {

            var vacina = _dataContext.Vacinas.FirstOrDefault(a => a.Id == animalVacinaDto.Vacina.Id);

            if (vacina == null)
                return NotFound("vacina não encontrada");

            AnimalVacina vscina = new AnimalVacina(
                vacina,
                animalVacinaDto.Dose,
                animalVacinaDto.Peso,
                animalVacinaDto.Data,
                animalVacinaDto.DataReforco,
                animalVacinaDto.DataVencimento,
                animalVacinaDto.Veterinario);
        }

        }
}
