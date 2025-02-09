var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Add services to the container.

var app = builder.Build();

app.UseRouting();
app.MapControllers();

app.Run();

 