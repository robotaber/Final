// Controllers/ClientesController.cs
using Microsoft.AspNetCore.Mvc;
using ClienteApi.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace ClienteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private static List<Cliente> _clientes = new List<Cliente>();

        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> GetClientes()
        {
            return Ok(_clientes.OrderBy(c => c.FechaNacimiento)); // Asegúrate de que aquí estés usando FechaNacimiento
        }

        [HttpPost]
        public ActionResult CrearCliente([FromBody] Cliente cliente)
        {
            _clientes.Add(cliente);
            return CreatedAtAction(nameof(GetClientes), new { id = cliente.Id }, cliente);
        }
    }
}
