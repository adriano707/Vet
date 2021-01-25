using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using Vet.Domain.Endereco;

namespace Vet.Data.Configuracoes
{
    public class EstadoConfiguracao : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.HasKey(a => a.Id);
        }
    }
}
