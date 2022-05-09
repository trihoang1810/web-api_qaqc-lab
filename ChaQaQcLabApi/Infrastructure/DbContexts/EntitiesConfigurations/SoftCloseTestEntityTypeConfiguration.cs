using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChaQaQcLabApi.Infrastructure.DbContexts.EntitiesConfigurations;

public class SoftCloseTestEntityTypeConfiguration : IEntityTypeConfiguration<SoftCloseTest>
{
    public void Configure(EntityTypeBuilder<SoftCloseTest> softCloseTestConfiguration)
    {
        softCloseTestConfiguration
            .HasKey(s => s.Id);
        softCloseTestConfiguration
            .HasIndex(s => s.Id)
            .IsUnique();
        softCloseTestConfiguration
            .Property(s => s.Id)
            .ValueGeneratedOnAdd();

        softCloseTestConfiguration
            .Property(s => s.StartDate)
            .IsRequired();

        softCloseTestConfiguration
            .Property(s => s.EndDate)
            .IsRequired();

        softCloseTestConfiguration
            .HasOne(s => s.Product)
            .WithMany()
            .HasForeignKey(s => s.ProductId);

        softCloseTestConfiguration
            .Property(s => s.TestPurpose)
            .IsRequired();

        softCloseTestConfiguration
            .Property(s => s.Note)
            .HasMaxLength(256)
            .IsRequired();

        softCloseTestConfiguration
            .OwnsMany(s => s.Samples,
            s =>
            {
                s.WithOwner();
                s.Property(s => s.NumberOfClosing)
                    .IsRequired();
                s.Property(s => s.NumberOfError)
                    .IsRequired();

                s.OwnsOne(s => s.SeatLidResult,
                    s =>
                    {
                        s.WithOwner();
                        s.Property(s => s.Passed).IsRequired();
                        s.Property(s => s.FallTime).IsRequired();
                        s.Property(s => s.IsUnleaked).IsRequired();
                        s.Property(s => s.IsBumperIntact).IsRequired();
                    });

                s.OwnsOne(s => s.SeatRingResult,
                    s =>
                    {
                        s.WithOwner();
                        s.Property(s => s.Passed)
                            .IsRequired();
                        s.Property(s => s.FallTime)
                            .IsRequired();
                        s.Property(s => s.IsUnleaked)
                            .IsRequired();
                        s.Property(s => s.IsBumperIntact)
                            .IsRequired();
                    });

                s.HasOne(s => s.Tester)
                    .WithMany()
                    .HasForeignKey(s => s.EmployeeId);
            });

    }
}
