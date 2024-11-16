using Microsoft.EntityFrameworkCore;
using ClienteApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Configuración de DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Agregar servicios al contenedor.
builder.Services.AddControllers();

var app = builder.Build();

// Configurar el pipeline de la aplicación.
app.UseHttpsRedirection();
app.MapControllers();

app.Run();
