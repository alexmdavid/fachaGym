namespace fachaGym.Service.IService
{
    using global::fachaGym.Models;

    namespace fachaGym.Services
    {
        public interface IUsuarioService
        {
            Task<IEnumerable<Usuario>> ObtenerTodos();
            Task<Usuario?> ObtenerPorId(int id);
            Task Crear(Usuario usuario);
            Task Actualizar(Usuario usuario);
            Task Eliminar(int id);
        }
    }

}
