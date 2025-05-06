using fachaGym.models;

namespace fachaGym.Service.IService
{
    public interface IRutinaService
    {
        Task<IEnumerable<Rutina>> ObtenerTodos();
        Task<Rutina?> ObtenerPorId(int id);
        Task Crear(Rutina rutina);
        Task Actualizar(Rutina rutina);
        Task Eliminar(int id);
    }
}
