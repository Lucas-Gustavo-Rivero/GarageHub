namespace GarageHub.Api.Models
{
    public enum EstadoEstadia
    {
        Activa, Finalizada
    }
    public class Estadia
    {
        public int Id { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime? FechaSalida { get; set; }
        public decimal TotalCobrado { get; set; }
        public EstadoEstadia Estado { get; set; }

        //Propiedades de navegacion
        public int VehiculoId { get; set; }
        public int LugarId { get; set; }
        public Vehiculo Vehiculo { get; set; } = null!;
        public Lugar Lugar { get; set; } = null!;
    }
}
