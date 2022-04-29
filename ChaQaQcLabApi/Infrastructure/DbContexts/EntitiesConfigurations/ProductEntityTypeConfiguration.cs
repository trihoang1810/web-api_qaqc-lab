using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChaQaQcLabApi.Infrastructure.DbContexts.EntitiesConfigurations;

public class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> productConfiguration)
    {
        productConfiguration
            .HasKey(p => p.Id);
        productConfiguration
            .HasIndex(p => p.Id)
            .IsUnique();
        productConfiguration
            .Property(p => p.Id)
            .HasMaxLength(40)
            .IsRequired();

        productConfiguration
            .Property(p => p.Name)
            .HasMaxLength(256)
            .IsRequired();
    }
}
