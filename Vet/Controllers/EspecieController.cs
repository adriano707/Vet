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
    [Route("especies")]
    public class EspecieController : ControllerBase
    {
        public EspecieController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        private readonly DataContext _dataContext;

        [HttpGet]
        public async Task<IActionResult> ObterEspecie()
        {
            var especies = _dataContext.Especie.ToList();
            return Ok(especies);
        }

        [HttpPost]
        public async Task<IActionResult> CriarEspecie([FromBody] EspecieDto especieDto)
        {
            Especie especies = new Especie(especieDto.Nome);
            _dataContext.Add(especies);
            await _dataContext.SaveChangesAsync();
            return Ok(especies);
        }
    }
}
