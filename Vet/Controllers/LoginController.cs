using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vet.Data;
using Vet.Domain.Login;
using Vet.Dtos.Login;

namespace Vet.Api.Controllers
{
    [ApiController]
    [Route("login")]
    public class LoginController : ControllerBase
    {
        public LoginController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        private readonly DataContext _dataContext;

        //[HttpGet]
        //public async Task<IActionResult> ObterLogin()
        //{

        //}

        [HttpPost]
        public async Task<IActionResult> CriarLogin([FromBody] LoginDto loginDto)
        {
            Login login = new Login(loginDto.Usuario, loginDto.Senha);
            _dataContext.Add(login);
            await _dataContext.SaveChangesAsync();
            return Ok(login);
        }
    }
}
