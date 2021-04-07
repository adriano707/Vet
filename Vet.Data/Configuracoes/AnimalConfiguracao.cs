using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vet.Domain.Animal;

namespace Vet.Data.Configuracoes
{
    public class AnimalConfiguracao : IEntityTypeConfiguration<Animal>
    {
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.HasKey(a => a.Id);
        }
    }
}
