using Microsoft.EntityFrameworkCore;
using Peliculas.Data;
using Peliculas.Models;

namespace Peliculas.Repositories
{
    public class PeliculaRepository : IPeliculaRepository
    {
        private readonly ApplicationDbContext _context;

        public PeliculaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Pelicula>> GetPeliculas(int page = 1, int pageSize = 5, string filter = null)
        {
            IQueryable<Pelicula> query = _context.Peliculas;

            if (!string.IsNullOrEmpty(filter))
            {
                query = query.Where(p => p.Titulo.Contains(filter));
            }

            return await query.Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }

        public async Task<Pelicula?> GetPeliculaById(int id)
        {
            return await _context.Peliculas.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Pelicula> CreatePelicula(Pelicula pelicula)
        {
            _context.Peliculas.Add(pelicula);
            await _context.SaveChangesAsync();
            return pelicula;
        }

        public async Task UpdatePelicula(Pelicula pelicula)
        {
            _context.Entry(pelicula).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeletePelicula(int id)
        {
            var pelicula = await _context.Peliculas.FindAsync(id);
            if (pelicula != null)
            {
                _context.Peliculas.Remove(pelicula);
                await _context.SaveChangesAsync();
            }
        }
        ~PeliculaRepository()
        {
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Liberar otros recursos administrados aquí
            }

            // Liberar los recursos no administrados (el objeto _context)
            _context.Dispose();
        }

        private void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


    }
}
