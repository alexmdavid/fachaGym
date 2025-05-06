using fachaGym.models;
using fachaGym.Repositories.IRepositories;
using fachaGym.Service.IService;

namespace fachaGym.Service
{
    public class PlanService: IPlanService
    {
        private readonly IPlanRepository planRepository;
        public PlanService(IPlanRepository planRepository)
        {
            this.planRepository = planRepository;
        }

        public async Task Actualizar(Plan plan)
        {
            await planRepository.Actualizar(plan);
        }

        public async Task Crear(Plan plan)
        {
            await planRepository.Crear(plan);
        }

        public async Task Eliminar(int id)
        {
            await planRepository.Eliminar(id);
        }

        public async Task<Plan?> ObtenerPorId(int id)
        {
            return await planRepository.ObtenerPorId(id);
        }

        public Task<IEnumerable<Plan>> ObtenerTodos()
        {
            return planRepository.ObtenerTodos();
        }
    }
}
