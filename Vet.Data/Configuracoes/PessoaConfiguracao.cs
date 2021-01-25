using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Domain.Pessoa;

namespace Vet.Data.Configuracoes
{
    public class PessoaConfiguracao : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasKey(a => a.Id);
        }
    }
}
