using Microservices.TaxasDeJuros.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Microservices.TaxasDeJuros.Data.Configs
{
    public class TaxaDeJurosEntityConfig : IEntityTypeConfiguration<TaxaDeJuros>
    {
        public void Configure(EntityTypeBuilder<TaxaDeJuros> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasDiscriminator()
                .HasValue<TaxaDeJurosPadrao>(nameof(TaxaDeJurosPadrao))
                .HasValue<TaxaDeJurosEspecial>(nameof(TaxaDeJurosEspecial));

            builder.HasIndex("Discriminator").IsUnique();
        }
    }
}