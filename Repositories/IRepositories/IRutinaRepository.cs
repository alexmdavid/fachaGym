using fachaGym.models;
using fachaGym.Models;

namespace fachaGym.Repositories.IRepositories
{
    public interface IRutinaRepository
    {
        Task<IEnumerable<Rutina>> ObtenerTodos();
        Task<Rutina?> ObtenerPorId(int id);
        Task Crear(Rutina rutina);
        Task Actualizar(Rutina rutina);
        Task Eliminar(int id);
    }
}
