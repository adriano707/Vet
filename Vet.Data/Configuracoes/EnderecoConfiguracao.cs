using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Domain.Endereco;

namespace Vet.Data.Configuracoes
{
    public class EnderecoConfiguracao : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(a => a.Id);
        }
    }
}
