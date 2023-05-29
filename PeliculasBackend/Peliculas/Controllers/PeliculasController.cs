using Microsoft.AspNetCore.Mvc;
using Peliculas.DTOs;
using Peliculas.Services;
using System.Threading.Tasks;

namespace Peliculas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeliculasController : ControllerBase
    {
        private readonly IPeliculaService _peliculaService;

        public PeliculasController(IPeliculaService peliculaService)
        {
            _peliculaService = peliculaService;
        }

        [HttpPost]
        public async Task<IActionResult> CrearPelicula([FromBody] PeliculaDTO peliculaDto)
        {
            var peliculaId = await _peliculaService.CrearPelicula(peliculaDto);
            return CreatedAtAction(nameof(ObtenerPelicula), new { id = peliculaId }, null);
        }

        [HttpPost("{peliculaId}/actores")]
        public async Task<IActionResult> AgregarActor(int peliculaId, [FromBody] ActorDTO actorDto)
        {
            await _peliculaService.AgregarActor(peliculaId, actorDto);
            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerPelicula(int id)
        {
            var peliculaDto = await _peliculaService.ObtenerPelicula(id);
            if (peliculaDto == null)
                return NotFound();

            return Ok(peliculaDto);
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerPeliculas(int pagina = 1, int total=5, string filtro = "")
        {
            var peliculasPaginadas = await _peliculaService.ObtenerPeliculas(pagina,total, filtro);
            return Ok(peliculasPaginadas);
        }
    }
}