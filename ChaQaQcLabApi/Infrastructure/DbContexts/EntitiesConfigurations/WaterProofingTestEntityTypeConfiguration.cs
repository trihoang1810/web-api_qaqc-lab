using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChaQaQcLabApi.Infrastructure.DbContexts.EntitiesConfigurations;

public class WaterProofingTestEntityTypeConfiguration : IEntityTypeConfiguration<WaterProofingTest>
{
    public void Configure(EntityTypeBuilder<WaterProofingTest> builder)
    {
        builder
            .HasKey(w => w.Id);
        builder
            .HasIndex(w => w.Id)
            .IsUnique();
        builder
            .Property(w => w.Id)
            .UseHiLo();

        builder
            .Property(w => w.StartDate)
            .IsRequired();

        builder
            .Property(w => w.EndDate)
            .IsRequired();

        builder
            .HasOne(w => w.Product)
            .WithMany()
            .HasForeignKey(w => w.ProductId);

        builder
            .Property(w => w.TestPurpose)
            .IsRequired();

        builder
            .Property(w => w.Note)
            .HasMaxLength(256)
            .IsRequired();

        builder
            .OwnsMany(w => w.Samples,
            w =>
            {
                w.WithOwner();
                w.Property(w => w.Temperature)
                    .IsRequired();
                w.Property(w => w.Duration)
                    .IsRequired();
                w.Property(w => w.Passed)
                    .IsRequired();
                w.Property(w => w.NumberOfError)
                    .IsRequired();
                w.Property(w => w.Note)
                    .IsRequired()
                    .HasMaxLength(256);
            });

        builder
            .HasOne(w => w.Tester)
            .WithMany()
            .HasForeignKey(w => w.EmployeeId);
    }
}
