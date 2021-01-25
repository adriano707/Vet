using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Domain.Animal;

namespace Vet.Data.Configuracoes
{
    public class EspecieConfiguracao : IEntityTypeConfiguration<Especie>
    {
        public void Configure(EntityTypeBuilder<Especie> builder)
        {
            builder.HasKey(a => a.Id);
        }
    }
}
