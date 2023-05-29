using NUnit.Framework;
using Moq;
using Peliculas.Services;
using Peliculas.Models;
using Peliculas.DTOs;
using Peliculas.Repositories;

namespace TestPeliculas
{
    [TestFixture]
    public class PeliculaServiceTests
    {
        private PeliculaService _peliculaService;
        private Mock<IPeliculaRepository> _peliculaRepositoryMock;

        [SetUp]
        public void Setup()
        {
            _peliculaRepositoryMock = new Mock<IPeliculaRepository>();
            _peliculaService = new PeliculaService(_peliculaRepositoryMock.Object);
        }

        [Test]
        public async Task CrearPelicula_DebeRetornarPeliculaDto()
        {
            // Arrange
            var peliculaDto = new PeliculaDTO
            {
                /* Propiedades de prueba */
            };

            // Act
            var result = await _peliculaService.CrearPelicula(peliculaDto);

            // Assert
            Assert.IsInstanceOf<PeliculaDTO>(result);
        }

        [Test]
        public async Task AgregarActor_DebeRetornarActorDto()
        {
            // Arrange
            int peliculaId = 1;
            var actorDto = new ActorDTO
            {
                /* Propiedades de prueba */
            };

            // Act
            ActorDTO result = await _peliculaService.AgregarActor(peliculaId, actorDto);

            // Assert
            Assert.IsInstanceOf<ActorDTO>(result);
        }

        [Test]
        public async Task ObtenerPelicula_DebeRetornarPeliculaDto()
        {
            // Arrange
            int peliculaId = 1;
            var pelicula = new Pelicula
            {
                /* Propiedades de prueba */
            };
            _peliculaRepositoryMock.Setup(r => r.GetPeliculaById(peliculaId)).ReturnsAsync(pelicula);

            // Act
            PeliculaDTO result = await _peliculaService.ObtenerPelicula(peliculaId);

            // Assert
            Assert.IsInstanceOf<PeliculaDTO>(result);
        }
    }
}

// Assert