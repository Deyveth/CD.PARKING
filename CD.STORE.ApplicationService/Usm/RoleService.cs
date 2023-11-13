using CD.STORE.Context;
using CD.STORE.Entities.Usm;
using CD.STORE.IApplicationService.Usm;
using CD.STORE.IRepositories.Usm;
using Microsoft.Extensions.Logging;

namespace CD.STORE.ApplicationService.Usm
{
    public class RoleService : IRoleService
    {
        private readonly ILogger<RoleService> _logger;
        private readonly StoreContext _context;
        private readonly IRoleRepository _roleRepository;

        public RoleService(ILogger<RoleService> logger, StoreContext context, IRoleRepository roleRepository)
        {
            _logger = logger;
            _context = context;
            _roleRepository = roleRepository;
        }

        public List<Role> GetAll()
        {
            try
            {
                List<Role> response = _roleRepository.GetAll().ToList();
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex, "");
                throw;
            }
        }
    }
}
