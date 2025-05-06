namespace fachaGym.Data
{
    using fachaGym.models;
    using fachaGym.Models;
    using Microsoft.EntityFrameworkCore;

    public class GymDbContext : DbContext
    {
        public GymDbContext(DbContextOptions<GymDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rutina> Rutinas { get; set; }
        public DbSet<Plan> Planes { get; set; }
        public DbSet<Producto> Productos{ get; set; }
        public DbSet<Admin> Admins { get; set; }
    }

}
