using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Domain.Endereco;

namespace Vet.Data.Configuracoes
{
    public class CidadeConfiguracao : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.HasKey(a => a.Id);
        }
    }
}
