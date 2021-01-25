using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Domain.Endereco;

namespace Vet.Data.Configuracoes
{
    public class BairroConfiguracao : IEntityTypeConfiguration<Bairro>
    {
        public void Configure(EntityTypeBuilder<Bairro> builder)
        {
            builder.HasKey(a => a.Id);
        }
    }
}
