using Microsoft.EntityFrameworkCore;
using Peleas.Models;
namespace Peleas.Models
{
    public class MvcContext : DbContext
    {
        public MvcContext (DbContextOptions<MvcContext> options)
            : base(options)
        {
        }

        public DbSet<Peleas.Models.Luchador> Luchador { get; set; }
        public DbSet<Peleas.Models.Lucha> Lucha { get; set; }
        public DbSet<Peleas.Models.Control> Control { get; set; }
    }
}