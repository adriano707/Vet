using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Domain.Animal;

namespace Vet.Data.Configuracoes
{
    public class AnimalVacinaConfiguracao : IEntityTypeConfiguration<AnimalVacina>
    {

        public void Configure(EntityTypeBuilder<AnimalVacina> builder)
        {
            builder.HasKey(a => a.Id);
        }
    }
}
