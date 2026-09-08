var builder = WebApplication.CreateBuilder(args);

// Agregamos los servicios para usar los controladores.
builder.Services.AddControllers();

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