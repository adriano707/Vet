using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Domain.Financeiro;

namespace Vet.Data.Configuracoes
{
    public class PedidoConfiguracao : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(a => a.Id);
        }
    }
}
