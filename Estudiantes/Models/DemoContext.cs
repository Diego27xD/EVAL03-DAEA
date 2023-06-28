using Microsoft.EntityFrameworkCore;
namespace Estudiantes.Models
{
    public class DemoContext: DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base(options)
        {
        }
        public DbSet<Estudiante> Student { set; get; }
    }
}
