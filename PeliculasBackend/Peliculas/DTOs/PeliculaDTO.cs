namespace Peliculas.DTOs
{
    public class PeliculaDTO
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Director { get; set; }
        public string Productora { get; set; }
        public DateTime FechaEstreno { get; set; }
        public List<ActorDTO> Actores { get; set; }
        public string FotoCartel { get; set; }
    }
}
