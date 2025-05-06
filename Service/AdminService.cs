using fachaGym.models;
using fachaGym.Repositories.IRepositories;
using fachaGym.Service.IService;

namespace fachaGym.Service
{
    public class AdminService: IAdminServices
    {
        private readonly IAdminRepository _repository;

        public AdminService(IAdminRepository repository)
        {
            _repository = repository;
        }
        public async Task Actualizar(Admin admin)
        {
            await _repository.Actualizar(admin);
        }

        public async Task Crear(Admin admin)
        {
            await _repository.Crear(admin);
        }

        public async Task Eliminar(int id)
        {
            await _repository.Eliminar(id);
        }

        public async Task<Admin?> ObtenerPorId(int id)
        {
            return await _repository.ObtenerPorId(id);
        }

        public async Task<IEnumerable<Admin>> ObtenerTodos()
        {
            return await _repository.ObtenerTodos();
        }
    }
}
