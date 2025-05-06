using fachaGym.Data;
using fachaGym.models;
using fachaGym.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace fachaGym.Repositories
{
    public class AdminRepository: IAdminRepository
    {
        private readonly GymDbContext _context;
        public AdminRepository(GymDbContext context)
        {
            _context = context;
        }

        public async Task Actualizar(Admin admin)
        {
            _context.Admins.Update(admin);
            await _context.SaveChangesAsync();
        }

        public async Task Crear(Admin admin)
        {
            _context.Admins.Add(admin);
            await _context.SaveChangesAsync();
        }

        public async Task Eliminar(int id)
        {
            var admin = await _context.Admins.FindAsync(id);
            if (admin != null)
            {
                _context.Admins.Remove(admin);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Admin?> ObtenerPorId(int id)
        {
            return await _context.Admins.FindAsync(id);
        }

        public async Task<IEnumerable<Admin>> ObtenerTodos()
        {
           return await _context.Admins.ToListAsync();
        }
    }
}
