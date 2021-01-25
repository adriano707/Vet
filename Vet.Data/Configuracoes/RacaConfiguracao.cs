using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Domain.Animal;

namespace Vet.Data.Configuracoes
{
    public class RacaConfiguracao : IEntityTypeConfiguration<Raca>
    {
        public void Configure(EntityTypeBuilder<Raca> builder)
        {
            builder.HasKey(a => a.Id);
        }
    }
}
