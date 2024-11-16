using Microsoft.EntityFrameworkCore;
using ClienteApi.Models;

namespace ClienteApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<InformacionCliente> InformacionesClientes { get; set; }
    }
}
