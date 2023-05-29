using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Peliculas.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Director { get; set; }
        public string Productora { get; set; }
        public DateTime FechaEstreno { get; set; }
        public string Actores { get; set; }
        public string FotoCartel { get; set; }

    }
}
