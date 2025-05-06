using fachaGym.Data;
using fachaGym.models;

namespace fachaGym.Repositories.IRepositories
{
    public interface IPlanRepository
    {
        Task<IEnumerable<Plan>> ObtenerTodos();
        Task<Plan?> ObtenerPorId(int id);
        Task Crear(Plan plan);
        Task Actualizar(Plan plan);
        Task Eliminar(int id);
    }
}
