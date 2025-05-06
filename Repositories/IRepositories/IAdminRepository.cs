using fachaGym.models;

namespace fachaGym.Repositories.IRepositories
{
    public interface IAdminRepository
    {
        Task<IEnumerable<Admin>> ObtenerTodos();
        Task<Admin?> ObtenerPorId(int id);
        Task Crear(Admin admin);
        Task Actualizar(Admin admin);
        Task Eliminar(int id);
    }
}
