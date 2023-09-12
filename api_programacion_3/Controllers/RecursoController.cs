using Microsoft.AspNetCore.Mvc;
using api_programacion_3.entities.recursos;

namespace api_programacion_3.Controllers;

[ApiController]
[Route("[controller]")]
public class RecursoController : ControllerBase
{
    private readonly ILogger<RecursoController> _logger;

    public RecursoController(ILogger<RecursoController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetRecurso")]
    public IEnumerable<Recurso> Get()
    {
        List<Recurso> recursos = new List<Recurso>();

        TipoRecurso bibliografia = new TipoRecurso
        {
            Id = 1,
            Descripcion = "Bibliografía"
        };

        recursos.Add(new Recurso
        {
            Id = 1,
            Descripcion = "Libro del Clean Code",
            Link = "...",
            TipoRecurso = bibliografia,
            Titulo = "Clean Code",
            UrlImagen = "..."
        });

        return recursos;
    }
}
