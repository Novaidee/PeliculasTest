using Peliculas.DTOs;

namespace Peliculas.Services
{

        public interface IPeliculaService
        {
            Task<PeliculaDTO> CrearPelicula(PeliculaDTO peliculaDto);
            Task<ActorDTO> AgregarActor(int peliculaId, ActorDTO actorDto);
            Task<PeliculaDTO> ObtenerPelicula(int peliculaId);
            Task<List<PeliculaDTO>> ObtenerPeliculas(int page, int pageSize, string filter = "");
        }

  
}
