namespace fachaGym.Data
{
    using fachaGym.Models;
    using Microsoft.EntityFrameworkCore;

    public class GymDbContext : DbContext
    {
        public GymDbContext(DbContextOptions<GymDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
    }

}
