namespace ClienteApi.Models
{
    public class InformacionCliente
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string TipoInformacion { get; set; } // Ej. Dirección, contactabilidad, etc.
        public string Valor { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string UsuarioCreador { get; set; }
        public string EstadoInformacion { get; set; }

        // Relación con Cliente
        public Cliente Cliente { get; set; }
    }
}
