using Microsoft.EntityFrameworkCore;
namespace Practica_1.Models
{
    public class ImpuestoContext : DbContext
    {
        public ImpuestoContext(DbContextOptions<ImpuestoContext> options) :
        base(options)
        {
        }
        public DbSet<Impuesto> Impuestos { get; set; }
    }
}