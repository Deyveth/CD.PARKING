using CD.STORE.Context;
using CD.STORE.Entities.Usm;
using CD.STORE.IRepositories.Usm;
using Microsoft.Extensions.Logging;

namespace CD.STORE.Repositories.Usm
{
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        private readonly ILogger<RoleRepository> _logger;
        private readonly StoreContext _context;

        public RoleRepository(ILogger<RoleRepository> logger, StoreContext context) : base(context)
        {
            _logger = logger;
            _context = context;
        }
    }
}
