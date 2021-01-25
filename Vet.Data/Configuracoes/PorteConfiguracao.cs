using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Domain.Animal;

namespace Vet.Data.Configuracoes
{
    public class PorteConfiguracao : IEntityTypeConfiguration<Porte>
    {
        public void Configure(EntityTypeBuilder<Porte> builder)
        {
            builder.HasKey(a => a.Id);
        }
    }
}
