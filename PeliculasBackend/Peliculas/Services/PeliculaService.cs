using Peliculas.Models;
using Peliculas.Repositories;
using Peliculas.DTOs;
using Newtonsoft.Json;
using Peliculas.Exceptions;

namespace Peliculas.Services
{
    public class PeliculaService : IPeliculaService
    {
        private readonly IPeliculaRepository _peliculaRepository;

        public PeliculaService(IPeliculaRepository peliculaRepository)
        {
            _peliculaRepository = peliculaRepository;
        }

        public async Task<PeliculaDTO> CrearPelicula(PeliculaDTO peliculaDto)
        {
            //Nuevo Id para Actores nuevos
            peliculaDto.Actores.ForEach(x=>x.Id=Guid.NewGuid().ToString());
            // Mapear el DTO de película a la entidad de película
            var pelicula = new Pelicula
            {
                Titulo = peliculaDto.Titulo,
                Director = peliculaDto.Director,
                Productora = peliculaDto.Productora,
                FechaEstreno = peliculaDto.FechaEstreno,
                Actores = JsonConvert.SerializeObject(peliculaDto.Actores),
                FotoCartel = peliculaDto.FotoCartel
            };

            // Crear la película en el repositorio
            pelicula = await _peliculaRepository.CreatePelicula(pelicula);

            // Mapear la entidad de película creada a un DTO de película y devolverlo
            return MapPeliculaToDto(pelicula);
        }

        public async Task<ActorDTO>AgregarActor(int peliculaId, ActorDTO actorDto)
        {
            // Obtener la película del repositorio por su ID
            var pelicula = await _peliculaRepository.GetPeliculaById(peliculaId);

            // Si la película existe, agregar el actor
            if (pelicula != null)
            {
                // Mapear el DTO de actor a la entidad de actor
                var actor = new Actor
                {
                    Id = Guid.NewGuid().ToString(),
                    Nombre = actorDto.Nombre,
                    Genero = actorDto.Genero,
                    FechaNacimiento = actorDto.FechaNacimiento,
                    PaisNacimiento = actorDto.PaisNacimiento
                };

                var actoresPelicula = string.IsNullOrEmpty(pelicula.Actores) ? new List<Actor>(): JsonConvert.DeserializeObject<List<Actor>>(pelicula.Actores);
                // Agregar el actor a la película
                if (actoresPelicula != null)
                {
                    actoresPelicula.Add(actor);
                    pelicula.Actores = JsonConvert.SerializeObject(actoresPelicula);
                }

                // Actualizar la película en el repositorio
               await _peliculaRepository.UpdatePelicula(pelicula);
               return actorDto;
            }

            throw new CustomException("La película no existe");
        }

        public async Task<PeliculaDTO> ObtenerPelicula(int peliculaId)
        {
            // Obtener las películas del repositorio
            var pelicula = await _peliculaRepository.GetPeliculaById(peliculaId);

            return MapPeliculaToDto(pelicula);
        }

        public async Task<List<PeliculaDTO>> ObtenerPeliculas(int page, int pageSize, string filter)
        {
            // Obtener las películas del repositorio
            var peliculas =await _peliculaRepository.GetPeliculas(page,pageSize,filter);

            // Mapear las entidades de película a DTOs de película y devolver la lista paginada
            return peliculas.Select(MapPeliculaToDto).ToList();
        }

        private Pelicula MapPeliculaDtoToModel(PeliculaDTO peliculaDto)
        {
            return new Pelicula
            {
                Id = peliculaDto.Id,
                Titulo = peliculaDto.Titulo,
                Director = peliculaDto.Director,
                Productora = peliculaDto.Productora,
                FechaEstreno = peliculaDto.FechaEstreno,
                Actores =JsonConvert.SerializeObject(peliculaDto.Actores),
                FotoCartel = peliculaDto.FotoCartel
            };
        }
        private PeliculaDTO MapPeliculaToDto(Pelicula pelicula)
        {


            return new PeliculaDTO
            {
                Id = pelicula.Id,
                Titulo = pelicula.Titulo,
                Director = pelicula.Director,
                Productora = pelicula.Productora,
                FechaEstreno = pelicula.FechaEstreno,
                Actores = (string.IsNullOrEmpty(pelicula.Actores)?new List<ActorDTO>():(JsonConvert.DeserializeObject<List<ActorDTO>>(pelicula.Actores))).Select(y=>y).ToList()!,
                FotoCartel = pelicula.FotoCartel
            };
        }

    }
}