using Microsoft.AspNetCore.Mvc;
using api_programacion_3.entities.recursos;

namespace api_programacion_3.Controllers;

[ApiController]
[Route("[controller]")]
public class BibliografiaController : ControllerBase
{
    private readonly ILogger<BibliografiaController> _logger;

    public BibliografiaController(ILogger<BibliografiaController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetBibliografia")]
    public IEnumerable<Bibliografia> Get()
    {
        List<Bibliografia> bibliografias = new List<Bibliografia>();

        bibliografias.Add(new Bibliografia
        {
            Id = 1,
            Descripcion = "Libro del Clean Code",
            Link = "#",
            Titulo = "Clean Code",
            UrlImagen = "https://images.cdn3.buscalibre.com/fit-in/360x360/10/fb/10fb170d7732b7dca25ebb81ded2572d.jpg"
        });

        return bibliografias;
    }
}
