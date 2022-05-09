using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChaQaQcLabApi.Infrastructure.DbContexts.EntitiesConfigurations;

public class ForcedCloseEntityTypeConfiguration : IEntityTypeConfiguration<ForcedCloseTest>
{
    public void Configure(EntityTypeBuilder<ForcedCloseTest> forcedCloseTestConfiguration)
    {
        forcedCloseTestConfiguration
            .HasKey(f => f.Id);
        forcedCloseTestConfiguration
            .HasIndex(f => f.Id)
            .IsUnique();
        forcedCloseTestConfiguration
            .Property(f => f.Id)
            .ValueGeneratedOnAdd();

        forcedCloseTestConfiguration
            .Property(f => f.StartDate)
            .IsRequired();

        forcedCloseTestConfiguration
            .Property(f => f.EndDate)
            .IsRequired();

        forcedCloseTestConfiguration
            .HasOne(f => f.Product)
            .WithMany()
            .HasForeignKey(f => f.ProductId);

        forcedCloseTestConfiguration
            .Property(f => f.TestPurpose)
            .IsRequired();

        forcedCloseTestConfiguration
            .Property(f => f.Note)
            .HasMaxLength(256)
            .IsRequired();


        forcedCloseTestConfiguration
            .OwnsMany(f => f.Samples,
            f =>
            {
                f.WithOwner();
                f.Property(f => f.NumberOfClosing)
                    .IsRequired();
                f.Property(f => f.NumberOfError)
                    .IsRequired();

                f.OwnsOne(f => f.SeatRingResult,
                    f =>
                    {
                        f.WithOwner();
                        f.Property(f => f.Passed)
                            .IsRequired();
                        f.Property(f => f.IsUnleaked)
                            .IsRequired();
                        f.Property(f => f.IsIntact)
                            .IsRequired();
                        f.Property(f => f.FallTime)
                            .IsRequired();
                    });

                f.OwnsOne(f => f.SeatLidResult,
                    f =>
                    {
                        f.WithOwner();
                        f.Property(f => f.Passed)
                            .IsRequired();
                        f.Property(f => f.IsUnleaked)
                            .IsRequired();
                        f.Property(f => f.IsIntact)
                            .IsRequired();
                        f.Property(f => f.FallTime)
                            .IsRequired();
                    });

                f.HasOne(f => f.Tester)
                    .WithMany()
                    .HasForeignKey(f => f.EmployeeId);
            });
    }
}
