using ChaQaQcLabApi.Mapping;

var builder = WebApplication.CreateBuilder(args);

#region Configure
builder.Services.AddControllers();
builder.Services.AddControllersWithViews();


builder.Services.AddAutoMapper(typeof(MappingProfile));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add services to the container.
builder.Services.AddScoped<ITesterService, TesterService>();
builder.Services.AddScoped<ICurlingForceTestService, CurlingForceTestService>();
builder.Services.AddScoped<IForcedCloseTestService, ForcedCloseTestService>();
builder.Services.AddScoped<IRockTestService, RockTestService>();
builder.Services.AddScoped<ISoftCloseTestService, SoftCloseTestService>();
builder.Services.AddScoped<IStaticLoadTestService, StaticLoadTestService>();
builder.Services.AddScoped<IProductService, ProductService>();

// Add Repos
builder.Services.AddScoped<ITesterRepository, TesterRepository>();
builder.Services.AddScoped<ICurlingForceTestRepository, CurlingForceTestRepository>();
builder.Services.AddScoped<IForcedCloseTestRepository, ForcedCloseTestRepository>();
builder.Services.AddScoped<IRockTestRepository, RockTestRepository>();
builder.Services.AddScoped<ISoftCloseTestRepository, SoftCloseTestRepository>();
builder.Services.AddScoped<IStaticLoadTestRepository, StaticLoadTestRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("LocalSqlServerIp"));
});
builder.Services.AddCors(options =>
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin();
        builder.AllowAnyHeader();
        builder.AllowAnyMethod();
    }
));
#endregion

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();