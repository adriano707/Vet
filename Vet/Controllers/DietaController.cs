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
    [Route("dietas")]
    public class DietaController : ControllerBase
    {
        public DietaController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        private readonly DataContext _dataContext;

        [HttpGet]
        public async Task<IActionResult> ObterDieta()
        {
            var dieta = _dataContext.Dieta.ToList();
            return Ok(dieta);
        }

        [HttpPost]
        public async Task<IActionResult> CriarDieta([FromBody] DietaDto dietaDto)
        {
            Dieta dieta = new Dieta(dietaDto.Descricao);
            _dataContext.Add(dieta);
            await _dataContext.SaveChangesAsync();
            return Ok(dieta);
        }
    }
}
