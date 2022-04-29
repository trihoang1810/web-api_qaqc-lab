using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChaQaQcLabApi.Infrastructure.DbContexts.EntitiesConfigurations;

public class CurlingForceTestEntityTypeConfiguration : IEntityTypeConfiguration<CurlingForceTest>
{
    public void Configure(EntityTypeBuilder<CurlingForceTest> curlingForceTestConfiguration)
    {
        curlingForceTestConfiguration
            .HasKey(c => c.Id);
        curlingForceTestConfiguration
            .HasIndex(c => c.Id)
            .IsUnique();
        curlingForceTestConfiguration
            .Property(c => c.Id)
            .UseHiLo();

        curlingForceTestConfiguration
            .Property(c => c.StartDate)
            .IsRequired();

        curlingForceTestConfiguration
            .Property(c => c.EndDate)
            .IsRequired();

        curlingForceTestConfiguration
            .HasOne(c => c.Product)
            .WithMany()
            .HasForeignKey(c => c.ProductId);

        curlingForceTestConfiguration
            .Property(c => c.TestPurpose)
            .IsRequired();

        curlingForceTestConfiguration
            .Property(c => c.Note)
            .HasMaxLength(256)
            .IsRequired();

        curlingForceTestConfiguration
            .OwnsMany(c => c.Samples,
            c =>
            {
                c.WithOwner();
                c.Property(c => c.SampleNumber)
                    .IsRequired();
                c.Property(c => c.Load)
                    .IsRequired();
                c.Property(c => c.Duration)
                    .IsRequired();
                c.Property(c => c.DeformationDegree)
                    .IsRequired();
                c.Property(c => c.NumberOfErrors)
                    .IsRequired();
                c.Property(c => c.Note)
                    .HasMaxLength(256)
                    .IsRequired();
            });

        curlingForceTestConfiguration
            .HasOne(c => c.Tester)
            .WithMany()
            .HasForeignKey(c => c.EmployeeId);
    }
}
