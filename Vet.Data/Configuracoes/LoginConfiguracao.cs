using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Domain.Login;

namespace Vet.Data.Configuracoes
{
    public class LoginConfiguracao : IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> builder)
        {
            builder.HasKey(a => a.Id);
        }
    }
}
