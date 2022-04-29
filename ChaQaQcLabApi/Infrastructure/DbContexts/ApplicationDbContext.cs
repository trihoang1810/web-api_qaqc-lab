using ChaQaQcLabApi.Infrastructure.DbContexts.EntitiesConfigurations;

namespace ChaQaQcLabApi.Infrastructure.DbContexts;

public class ApplicationDbContext : DbContext
{
    public DbSet<Tester> Testers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<CurlingForceTest> CurlingForceTests { get; set; }
    public DbSet<CurlingForceTestSample> CurlingForceTestSamples { get; set; }
    public DbSet<ForcedCloseTest> ForcedCloseTests { get; set; }
    public DbSet<ForcedCloseTestSample> ForcedCloseTestSamples { get; set; }
    public DbSet<ForcedCloseTestSampleResult> ForcedCloseTestSampleResults { get; set; }
    public DbSet<RockTest> RockTests { get; set; }
    public DbSet<RockTestSample> RockTestSamples { get; set; }
    public DbSet<SoftCloseTest> SoftCloseTests { get; set; }
    public DbSet<SoftCloseTestSample> SoftCloseTestSamples { get; set; }
    public DbSet<SoftCloseTestSampleResult> SoftCloseTestSampleResults { get; set; }
    public DbSet<StaticLoadTest> StaticLoadTests { get; set; }
    public DbSet<StaticLoadTestSample> StaticLoadTestSamples { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public ApplicationDbContext(DbContextOptions options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new TesterEntityTypeConfiguration());
        builder.ApplyConfiguration(new ProductEntityTypeConfiguration());
        builder.ApplyConfiguration(new CurlingForceTestEntityTypeConfiguration());
        builder.ApplyConfiguration(new ForcedCloseEntityTypeConfiguration());
        builder.ApplyConfiguration(new RockTestEntityTypeConfiguration());
        builder.ApplyConfiguration(new SoftCloseTestEntityTypeConfiguration());
        builder.ApplyConfiguration(new StaticLoadTestEntityTypeConfiguration());
    }
}
