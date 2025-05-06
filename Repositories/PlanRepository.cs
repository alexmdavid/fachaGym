using fachaGym.Data;
using fachaGym.models;
using fachaGym.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace fachaGym.Repositories
{
    public class PlanRepository: IPlanRepository
    {
        private readonly GymDbContext _context;

        public PlanRepository(GymDbContext context)
        {
            _context = context;
        }

        public async Task Actualizar(Plan plan)
        {
            _context.Planes.Update(plan);
            await _context.SaveChangesAsync();
        }

        public async Task Crear(Plan plan)
        {
            _context.Planes.Add(plan);
            await _context.SaveChangesAsync();
        }

        public async Task Eliminar(int id)
        {
            var plan = await _context.Planes.FindAsync(id);
            if (plan != null)
            {
                _context.Planes.Remove(plan);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Plan?> ObtenerPorId(int id)
        {
            return await _context.Planes.FindAsync(id);
        }

        public async Task<IEnumerable<Plan>> ObtenerTodos()
        {
            return await _context.Planes.ToListAsync();
        }
    }
}
