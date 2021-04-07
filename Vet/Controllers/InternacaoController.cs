using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Data;
using Vet.Domain.Internacao;
using Vet.Dtos.Internacao;

namespace Vet.Api.Controllers
{
    [ApiController]
    [Route("Internacoes")]
    public class InternacaoController : ControllerBase
    {
        public InternacaoController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        private readonly DataContext _dataContext;

        [HttpGet]
        public async Task<IActionResult> CriarInternacao([FromBody] InternacaoDto internacaoDto)
        {
            Internacao internacao = new Internacao(internacaoDto.Data, internacaoDto.PrevisaoAlta,
                internacaoDto.Animal, internacaoDto.Observacoes);
        }
    }
}
