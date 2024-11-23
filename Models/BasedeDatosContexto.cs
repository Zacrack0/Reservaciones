using Microsoft.EntityFrameworkCore;

namespace Reservaciones.Models
{
    public class BasedeDatosContexto : DbContext
    {
        public BasedeDatosContexto(DbContextOptions<BasedeDatosContexto> options) : base(options) { }
        public DbSet<Reserva> Reservaciones { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Sala> Salas { get; set; }
    }
}
