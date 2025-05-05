namespace fachaGym.Repositories.IRepositories
{
    using global::fachaGym.Models;

    namespace fachaGym.Repositories
    {
        public interface IUsuarioRepository
        {
            Task<IEnumerable<Usuario>> ObtenerTodos();
            Task<Usuario?> ObtenerPorId(int id);
            Task Crear(Usuario usuario);
            Task Actualizar(Usuario usuario);
            Task Eliminar(int id);
        }
    }

}
