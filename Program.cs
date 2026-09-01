using Microsoft.EntityFrameworkCore;
using MiApiCuadrado.Data;

var builder = WebApplication.CreateBuilder(args);

// Agregamos los servicios para usar los controladores.
builder.Services.AddControllers();

// Configuramos Entity Framework para conectarnos a SQL Server.
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    ));

// Agregamos OpenAPI para documentar nuestra API.
builder.Services.AddOpenApi();

var app = builder.Build();

// Configuramos OpenAPI cuando estamos trabajando en desarrollo.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Activamos la autorizacion.
app.UseAuthorization();

// Permitimos utilizar los controladores.
app.MapControllers();

app.Run();