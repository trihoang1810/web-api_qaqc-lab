using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChaQaQcLabApi.Infrastructure.DbContexts.EntitiesConfigurations;

public class RockTestEntityTypeConfiguration : IEntityTypeConfiguration<RockTest>
{
    public void Configure(EntityTypeBuilder<RockTest> rockTestConfiguration)
    {
        rockTestConfiguration
            .HasKey(r => r.Id);
        rockTestConfiguration
            .HasIndex(r => r.Id)
            .IsUnique();
        rockTestConfiguration
            .Property(r => r.Id)
            .UseHiLo();

        rockTestConfiguration
            .Property(r => r.StartDate)
            .IsRequired();

        rockTestConfiguration
            .Property(r => r.EndDate)
            .IsRequired();

        rockTestConfiguration
            .HasOne(r => r.Product)
            .WithMany()
            .HasForeignKey(r => r.ProductId);

        rockTestConfiguration
            .Property(r => r.TestPurpose)
            .IsRequired();

        rockTestConfiguration
            .Property(r => r.Note)
            .HasMaxLength(256)
            .IsRequired();

        rockTestConfiguration
            .OwnsMany(r => r.Samples,
            r =>
            {
                r.WithOwner();
                r.Property(r => r.Load)
                    .IsRequired();
                r.Property(r => r.TestedTimes)
                    .IsRequired();
                r.Property(r => r.Passed)
                    .IsRequired();
                r.Property(r => r.Note)
                    .IsRequired()
                    .HasMaxLength(256);
                r.Property(r => r.NumberOfErrors)
                    .IsRequired();
            });

        rockTestConfiguration
            .HasOne(r => r.Tester)
            .WithMany()
            .HasForeignKey(r => r.EmployeeId);
    }
}
