using Microsoft.EntityFrameworkCore;

namespace LightFeatherProj.Models
{
    public class SupervisorContext : DbContext
    {
        public SupervisorContext(DbContextOptions<SupervisorContext> options) : base(options)
        {
        }

        public DbSet<Supervisor> Supervisors { get; set; } = null!;
    }
}
