namespace ClienteApi.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Genero { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Estado { get; set; }
        public List<InformacionCliente> Informaciones { get; set; }
    }
}
