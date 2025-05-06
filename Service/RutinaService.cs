using fachaGym.models;
using fachaGym.Repositories.IRepositories;
using fachaGym.Service.IService;

namespace fachaGym.Service
{
    public class RutinaService : IRutinaService
    {
        private readonly IRutinaRepository _repo;
        public RutinaService(IRutinaRepository repo)
        {
            _repo = repo;
        }

        public Task Actualizar(Rutina rutina) => _repo.Actualizar(rutina);

        public Task Crear(Rutina rutina) => _repo.Crear(rutina);
        

        public Task Eliminar(int id) => _repo.Eliminar(id);


        public Task<Rutina?> ObtenerPorId(int id) => _repo.ObtenerPorId(id);
       

        public Task<IEnumerable<Rutina>> ObtenerTodos() => _repo.ObtenerTodos();
        
    }
}
