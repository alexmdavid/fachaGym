namespace fachaGym.Repositories
{
    using global::fachaGym.Data;
    using global::fachaGym.Models;
    using global::fachaGym.Repositories.IRepositories.fachaGym.Repositories;
    using Microsoft.EntityFrameworkCore;

    namespace fachaGym.Repositories
    {
        public class UsuarioRepository : IUsuarioRepository
        {
            private readonly GymDbContext _context;

            public UsuarioRepository(GymDbContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<Usuario>> ObtenerTodos()
            {
                return await _context.Usuarios.ToListAsync();
            }

            public async Task<Usuario?> ObtenerPorId(int id)
            {
                return await _context.Usuarios.FindAsync(id);
            }

            public async Task Crear(Usuario usuario)
            {
      
                _context.Usuarios.Add(usuario);
                await _context.SaveChangesAsync();
            }

            public async Task Actualizar(Usuario usuario)
            {
                _context.Usuarios.Update(usuario);
                await _context.SaveChangesAsync();
            }

            public async Task Eliminar(int id)
            {
                var usuario = await _context.Usuarios.FindAsync(id);
                if (usuario != null)
                {
                    _context.Usuarios.Remove(usuario);
                    await _context.SaveChangesAsync();
                }
            }
        }
    }

}
