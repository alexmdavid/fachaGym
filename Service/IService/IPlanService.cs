using fachaGym.models;

namespace fachaGym.Service.IService
{
    public interface IPlanService
    {
        Task<IEnumerable<Plan>> ObtenerTodos();
        Task<Plan?> ObtenerPorId(int id);
        Task Crear(Plan plan);
        Task Actualizar(Plan plan);
        Task Eliminar(int id);
    }
}
