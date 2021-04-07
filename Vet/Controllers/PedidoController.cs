using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vet.Data;
using Vet.Domain.Financeiro;
using Vet.Dtos.Financeiro;

namespace Vet.Api.Controllers
{
    [ApiController]
    [Route("padidos")]
    public class PedidoController : ControllerBase
    {
        public PedidoController(DataContext datacontext)
        {
            _dataContext = datacontext;
        }

        private readonly DataContext _dataContext;

        [HttpGet]
        public async Task<IActionResult> ObterPedido()
        {
            var pedido = _dataContext.Pedido.ToList();
            return Ok(pedido);
        }

        [HttpPost]
        public async Task<IActionResult> CriarPedido([FromBody] PedidoDto pedidoDto)
        {

            var clientePedido = _dataContext.Cliente.FirstOrDefault(a => a.Id == pedidoDto.Id);

            Pedido pedido = new Pedido(clientePedido,
                pedidoDto.Numero,
                pedidoDto.Observacoes,
                pedidoDto.Total,
                pedidoDto.Usuario);
            _dataContext.Add(pedido);
            await _dataContext.SaveChangesAsync();
            return Ok(pedido);
        }
    }
}
