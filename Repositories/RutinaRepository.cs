using fachaGym.Data;
using fachaGym.models;
using fachaGym.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace fachaGym.Repositories
{
    public class RutinaRepository : IRutinaRepository
    {
        private readonly GymDbContext _context;
        public RutinaRepository(GymDbContext _context) { 
            this._context = _context;
        }
        public async Task Actualizar(Rutina rutina)
        {
            _context.Rutinas.Update(rutina);
            _context.SaveChanges();
        }

        public async Task Crear(Rutina rutina)
        {
            _context.Rutinas.Add(rutina);
            _context.SaveChanges();
        }

        public async Task Eliminar(int id)
        {
            var rutina = await _context.Rutinas.FindAsync(id);
            if (rutina != null)
            {
                _context.Rutinas.Remove(rutina);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Rutina?> ObtenerPorId(int id)
        {
            return await _context.Rutinas.FindAsync(id);
        }

        public async Task<IEnumerable<Rutina>> ObtenerTodos()
        {
            return await _context.Rutinas.ToListAsync();
        }
    }
}
