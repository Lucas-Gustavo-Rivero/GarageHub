namespace GarageHub.Api.Models
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public string Patente { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;

        // Propiedades de navegacion

        public ICollection<Estadia> Estadias { get; set; } = new HashSet<Estadia>();
    }
}
