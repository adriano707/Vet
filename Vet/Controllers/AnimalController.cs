using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Domain.Animal;
using Vet.Dtos.Animal;
using Vet.Dtos;
using Vet.Data;

namespace Vet.Api.Controllers
{
    [ApiController]
    [Route("animais")]
    public class AnimalController : ControllerBase
    {
        public AnimalController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        private readonly DataContext _dataContext;

        [HttpGet]
        public async Task<IActionResult> ObterAnimal()
        {
            var animal = _dataContext.Animal.ToList();
            return Ok(animal);
        }

        [HttpPost]
        public async Task<IActionResult> CriarAnimal([FromBody] AnimalDto animalDto)
        {
            Animal animal = new Animal(animalDto.Nome);
            _dataContext.Add(animal);
            await _dataContext.SaveChangesAsync();
            return Ok(animal);
        }

    }
}
