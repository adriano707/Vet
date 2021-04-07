using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Data;

namespace Vet.Api.Controllers
{

    [ApiController]
    [Route("clientes")]
    public class ClienteController : ControllerBase
    {
        public ClienteController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        private readonly DataContext _dataContext;

        [HttpGet]
        public async Task<IActionResult> ObterCliente()
        {
            var cliente = _dataContext.Cliente.ToList();
            return Ok(cliente);
        }

        //[HttpPost]
        //public async Task<IActionResult> CriarCliente([FromBody] ClienteDto)
    }
}
