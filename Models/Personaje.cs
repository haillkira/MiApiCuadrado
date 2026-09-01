namespace MiApiCuadrado.Models
{
    // Esta clase representa la tabla Personajes de nuestra base de datos.
    public class Personaje
    {
        // Identificador unico del personaje.
        public int Id { get; set; }

        // Nombre del personaje.
        public string Nombre { get; set; } = string.Empty;

        // Tripulacion a la que pertenece.
        public string Tripulacion { get; set; } = string.Empty;

        // Fruta del diablo que posee.
        public string? Fruta { get; set; }

        // Recompensa del personaje.
        public long? Recompensa { get; set; }

        // Edad del personaje.
        public int? Edad { get; set; }

        // Rol que tiene dentro de su grupo.
        public string? Rol { get; set; }
    }
}