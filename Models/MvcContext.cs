using Microsoft.EntityFrameworkCore;

namespace Peleas.Models
{
    public class MvcContext : DbContext
    {
        public MvcContext (DbContextOptions<MvcContext> options)
            : base(options)
        {
        }

        public DbSet<Peleas.Models.Luchador> Luchador { get; set; }
    }
}