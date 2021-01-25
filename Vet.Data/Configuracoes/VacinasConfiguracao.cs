﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Domain.Produto;

namespace Vet.Data.Configuracoes
{
    public class VacinasConfiguracao : IEntityTypeConfiguration<Vacinas>
    {
        public void Configure(EntityTypeBuilder<Vacinas> builder)
        {
            builder.HasKey(a => a.Id);
        }
    }
}
