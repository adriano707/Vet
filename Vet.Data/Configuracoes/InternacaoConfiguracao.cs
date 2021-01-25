using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Domain.Internacao;

namespace Vet.Data.Configuracoes
{
    public class InternacaoConfiguracao : IEntityTypeConfiguration<Internacao>
    {
        public void Configure(EntityTypeBuilder<Internacao> builder)
        {
            builder.HasKey(a => a.Id);
        }
    }
}
