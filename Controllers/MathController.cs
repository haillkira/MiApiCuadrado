using Microsoft.AspNetCore.Mvc;


// Aqui importamos las herramientas que necesitamos pa trabajar con los controladores de ASP.NET Core.

namespace MiApi.Controllers;

// Aqui estamos diciendo que este archivo pertenece al espacio de nombres de nuestra API.

[ApiController]
// Esto le dice a ASP.NET que esta clase va a funcionar como un controlador de una API.

[Route("api/[controller]")]
// Aqui definimos la ruta de la API.
// [controller] se cambia automaticamente por el nombre del controlador.
// Como se llama MathController, la ruta base queda:
// api/Math

public class MathController : ControllerBase
// Aqui creamos el controlador llamado MathController.
// ControllerBase nos da las funciones necesarias pa responder solicitudes HTTP.
{
    [HttpGet("cuadrado/{numero:int}")]
    // Aqui decimos que vamos a recibir una solicitud GET.
    // La ruta sera algo como:
    // api/Math/cuadrado/5
    // {numero:int} significa que numero tiene que ser un entero.

    public IActionResult Cuadrado(int numero)
    // Aqui creamos el metodo Cuadrado.
    // Recibe un numero entero llamado numero.
    // IActionResult permite devolver diferentes tipos de respuestas HTTP.
    {
        if (numero < 0)
        // Aqui chequeamos si el numero que mandaron es menor que cero.
        {
            return BadRequest("El numero debe ser mayor o igual a 0.");
            // Si mandan un numero negativo, devolvemos un mensaje indicando que hay un error sin eso del 404 no found.
            // O sea, la API le dice al usuario que ese dato no es valido.
        }

        return Ok(numero * numero);
        // Si todo esta bien, multiplicamos el numero por el mismo.
        // Ejemplo: 5 * 5 = 25.
        // Ok() devuelve una respuesta HTTP 200, indicando que todo salio bien.
    }
}