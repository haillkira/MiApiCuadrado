using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using MiApiCuadrado.Models;

namespace MiApiCuadrado.Controllers
{
    // Este controlador se encarga de trabajar con los personajes de One Piece
    [ApiController]
    [Route("api/[controller]")]
    public class PersonajesController : ControllerBase
    {
        // Aqui guardamos la cadena de conexion con SQL Server
        private readonly string _connectionString;

        // Constructor que recibe la configuracion de la aplicacion
        public PersonajesController(IConfiguration configuration)
        {
            // Buscamos la cadena llamada DefaultConnection en appsettings.json
            _connectionString = configuration.GetConnectionString("DefaultConnection")!;
        }

        // Este metodo obtiene todos los personajes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Personaje>>> GetPersonajes()
        {
            // Abrimos una conexion con SQL Server
            using var connection = new SqlConnection(_connectionString);

            // Hacemos la consulta para buscar todos los personajes
            var personajes = await connection.QueryAsync<Personaje>(
                "SELECT * FROM Personajes ORDER BY Id"
            );

            // Devolvemos los personajes en formato JSON
            return Ok(personajes);
        }
    }
}