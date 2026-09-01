using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiApiCuadrado.Data;
using MiApiCuadrado.Models;

namespace MiApiCuadrado.Controllers
{
    // Este controlador se encarga de trabajar con los personajes de One Piece.
    [ApiController]
    [Route("api/[controller]")]
    public class PersonajesController : ControllerBase
    {
        // Conexion con la base de datos.
        private readonly AppDbContext _context;

        // Constructor que recibe la conexion a la base de datos.
        public PersonajesController(AppDbContext context)
        {
            _context = context;
        }

        // Este metodo obtiene todos los personajes.
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Personaje>>> GetPersonajes()
        {
            // Buscamos todos los personajes en la tabla.
            var personajes = await _context.Personajes.ToListAsync();

            // Devolvemos los personajes en formato JSON.
            return Ok(personajes);
        }
    }
}