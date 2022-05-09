using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChaQaQcLabApi.Infrastructure.DbContexts.EntitiesConfigurations;

public class StaticLoadTestEntityTypeConfiguration : IEntityTypeConfiguration<StaticLoadTest>
{
    public void Configure(EntityTypeBuilder<StaticLoadTest> staticLoadTestConfiguration)
    {
        staticLoadTestConfiguration
            .HasKey(s => s.Id);
        staticLoadTestConfiguration
            .HasIndex(s => s.Id)
            .IsUnique();
        staticLoadTestConfiguration
            .Property(s => s.Id)
            .ValueGeneratedOnAdd();

        staticLoadTestConfiguration
            .Property(s => s.StartDate)
            .IsRequired();

        staticLoadTestConfiguration
            .Property(s => s.EndDate)
            .IsRequired();

        staticLoadTestConfiguration
            .HasOne(s => s.Product)
            .WithMany()
            .HasForeignKey(s => s.ProductId);

        staticLoadTestConfiguration
            .Property(s => s.TestPurpose)
            .IsRequired();

        staticLoadTestConfiguration
            .Property(s => s.Note)
            .HasMaxLength(256)
            .IsRequired();

        staticLoadTestConfiguration
            .OwnsMany(s => s.Samples,
            s =>
            {
                s.WithOwner();
                s.Property(s => s.Status)
                    .IsRequired();
                s.Property(s => s.NumberOfError)
                    .IsRequired();

                s.HasOne(s => s.Tester)
                    .WithMany()
                    .HasForeignKey(s => s.EmployeeId);
            });
    }
}
