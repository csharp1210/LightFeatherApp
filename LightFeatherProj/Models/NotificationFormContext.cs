using Microsoft.EntityFrameworkCore;

namespace LightFeatherProj.Models
{
    public class NotificationFormContext : DbContext
    {
        public NotificationFormContext(DbContextOptions<NotificationFormContext> options) : base(options)
        { 
        }

        public DbSet<NotificationForm> NotificationForms { get; set; } = null!;
    }
}
