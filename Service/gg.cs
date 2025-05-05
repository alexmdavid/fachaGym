namespace fachaGym.Service
{
    using global::fachaGym.Models;
    using global::fachaGym.Repositories.IRepositories.fachaGym.Repositories;
    using global::fachaGym.Service.IService.fachaGym.Services;

    namespace fachaGym.Services
    {
        public class UsuarioService : IUsuarioService
        {
            private readonly IUsuarioRepository _repo;

            public UsuarioService(IUsuarioRepository repo)
            {
                _repo = repo;
            }

            public Task<IEnumerable<Usuario>> ObtenerTodos() => _repo.ObtenerTodos();
            public Task<Usuario?> ObtenerPorId(int id) => _repo.ObtenerPorId(id);
            public Task Crear(Usuario usuario) => _repo.Crear(usuario);
            public Task Actualizar(Usuario usuario) => _repo.Actualizar(usuario);
            public Task Eliminar(int id) => _repo.Eliminar(id);
        }
    }

}
