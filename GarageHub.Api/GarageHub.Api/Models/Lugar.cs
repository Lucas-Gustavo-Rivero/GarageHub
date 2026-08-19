using System.ComponentModel.DataAnnotations;

namespace GarageHub.Api.Models
{
    public enum EstadoLugar
    {
        Libre, Ocupado
    }
    public class Lugar
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = string.Empty;
        public EstadoLugar Estado { get; set; }
        
        [Timestamp]
        public byte[] RowVersion { get; set; } = Array.Empty<byte>();

        //Propiedades de navegacion

        public ICollection<Estadia> Estadias = new HashSet<Estadia>();
    }
}
