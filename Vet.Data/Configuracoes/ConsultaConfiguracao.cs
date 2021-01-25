using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Domain.Consulta;

namespace Vet.Data.Configuracoes
{
    public class ConsultaConfiguracao : IEntityTypeConfiguration<Consulta>
    {
        public void Configure(EntityTypeBuilder<Consulta> builder)
        {
            builder.HasKey(a => a.Id);
        }
    }
}
