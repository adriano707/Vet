using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Domain.Produto;

namespace Vet.Data.Configuracoes
{
    public class TipoConfiguracao : IEntityTypeConfiguration<Tipo>
    {
        public void Configure(EntityTypeBuilder<Tipo> builder)
        {
            builder.HasKey(a => a.Id);
        }
    }
}
