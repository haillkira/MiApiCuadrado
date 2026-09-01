using Microsoft.EntityFrameworkCore;
using MiApiCuadrado.Models;

namespace MiApiCuadrado.Data
{
    // Esta clase conecta nuestra API con la base de datos.
    public class AppDbContext : DbContext
    {
        // Constructor que recibe la configuracion de Entity Framework.
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Esta propiedad representa la tabla Personajes de SQL Server.
        public DbSet<Personaje> Personajes { get; set; }
    }
}