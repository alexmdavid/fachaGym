using fachaGym.models;

namespace fachaGym.Service.IService
{
    public interface IAdminServices
    {
        Task<IEnumerable<Admin>> ObtenerTodos();
        Task<Admin?> ObtenerPorId(int id);
        Task Crear(Admin admin);
        Task Actualizar(Admin admin);
        Task Eliminar(int id);
    }
}
