using Microsoft.EntityFrameworkCore;
using Peliculas.Models;

namespace Peliculas.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Pelicula> Peliculas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Mapeo de la tabla Pelicula
            modelBuilder.Entity<Pelicula>()
                .ToTable("Peliculas"); // Nombre de la tabla en la base de datos

            // Configuración de la entidad Pelicula
            modelBuilder.Entity<Pelicula>()
                .HasKey(p => p.Id); // Definir la clave primaria

            modelBuilder.Entity<Pelicula>()
                .Property(p => p.Titulo)
                .IsRequired(); // Indicar que el título es obligatorio

            modelBuilder.Entity<Pelicula>()
                .Property(p => p.Director)
                .IsRequired(); // Indicar que el director es obligatorio

            // Si deseas agregar más configuraciones para otras entidades, puedes hacerlo aquí

            base.OnModelCreating(modelBuilder);
        }

    }
}
