// Models/Cliente.cs
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClienteApi.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required] // Indica que esta propiedad es obligatoria
        public string Nombres { get; set; }

        [Required]
        public string Apellidos { get; set; }

        [Required]
        public string Genero { get; set; }

        [Required]
        public string Estado { get; set; }

        // Si Informaciones puede ser opcional, puedes permitir null
        public List<InformacionCliente>? Informaciones { get; set; } 
    }
}
