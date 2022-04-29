using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChaQaQcLabApi.Infrastructure.DbContexts.EntitiesConfigurations;

public class TesterEntityTypeConfiguration : IEntityTypeConfiguration<Tester>
{
    public void Configure(EntityTypeBuilder<Tester> testerConfiguration)
    {
        testerConfiguration
            .HasKey(p => p.EmployeeId);
        testerConfiguration
            .HasIndex(p => p.EmployeeId)
            .IsUnique();
        testerConfiguration
            .Property(p => p.EmployeeId)
            .HasMaxLength(20)
            .IsRequired();

        testerConfiguration
            .Property(p => p.FirstName)
            .HasMaxLength(40)
            .IsRequired();

        testerConfiguration
            .Property(p => p.LastName)
            .HasMaxLength(40)
            .IsRequired();
    }
}
