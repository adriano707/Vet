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
    [Route("habitat")]
    public class HabitatController : ControllerBase
    {
        public HabitatController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        private readonly DataContext _dataContext;

        [HttpGet]
        public async Task<IActionResult> ObterHabitat()
        {
            var habitat = _dataContext.Habitat.ToList();
            return Ok(habitat);
        }

        [HttpPost]
        public async Task<IActionResult> CriarHabitat([FromBody] HabitatDto habitatDto)
        {
            Habitat habitat = new Habitat(habitatDto.Nome);
            _dataContext.Add(habitat);
            await _dataContext.SaveChangesAsync();
            return Ok(habitat);
        }
    }
}
