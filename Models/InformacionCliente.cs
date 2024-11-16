// Models/InformacionCliente.cs
using System;
using System.ComponentModel.DataAnnotations;

namespace ClienteApi.Models
{
    public class InformacionCliente
    {
        public int Id { get; set; }

        [Required]
        public string TipoInformacion { get; set; }

        [Required]
        public string Valor { get; set; }

        [Required]
        public string UsuarioCreador { get; set; }

        [Required]
        public string EstadoInformacion { get; set; }

        // Si el Cliente puede ser nulo, puedes ponerlo como nullable
        public Cliente? Cliente { get; set; }
    }
}
