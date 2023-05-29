using Peliculas.Models;

namespace Peliculas.Repositories
{
    public interface IPeliculaRepository
    {
        Task<List<Pelicula>> GetPeliculas(int page = 1, int pageSize = 5, string filter = null);
        Task<Pelicula?> GetPeliculaById(int id);
        Task<Pelicula> CreatePelicula(Pelicula pelicula);
        Task UpdatePelicula(Pelicula pelicula);
        Task DeletePelicula(int id);
    }
}
