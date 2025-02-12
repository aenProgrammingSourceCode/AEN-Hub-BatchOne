using Microsoft.EntityFrameworkCore;
using WebApplicationKarim.Feature.DataAccess;
using WebApplicationKarim.Feature.DataAccess.Repositories;
using WebApplicationKarim.Feature.ServiceImplementation;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<KarimDbContext>(options=>options
.UseSqlServer(builder.Configuration.GetConnectionString("KarimConnectionString")),ServiceLifetime.Scoped);

builder.Services.AddTransient<ICompanyRepository, CompanyRepository>();
builder.Services.AddTransient<ICompanyService, CompanyService>();


// Add services to the container.

var app = builder.Build();

app.UseRouting();
app.MapControllers();

app.Run();

 