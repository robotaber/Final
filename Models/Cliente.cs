// Models/Cliente.cs
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClienteApi.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required]
        public string Nombres { get; set; }

        [Required]
        public string Apellidos { get; set; }

        [Required]
        public string Genero { get; set; }

        [Required]
        public string Estado { get; set; }

        // Nueva propiedad para Fecha de nacimiento
        [Required]
        public DateTime FechaNacimiento { get; set; } // Asegúrate de agregar esta propiedad

        public List<InformacionCliente> Informaciones { get; set; }
    }
}
