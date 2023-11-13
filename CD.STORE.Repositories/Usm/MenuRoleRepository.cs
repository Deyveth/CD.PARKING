using CD.STORE.Context;
using CD.STORE.Entities.Usm;
using CD.STORE.IRepositories.Usm;
using Microsoft.Extensions.Logging;

namespace CD.STORE.Repositories.Usm
{
    public class MenuRoleRepository : BaseRepository<MenuRole>, IMenuRoleRepository
    {
        private readonly ILogger<MenuRoleRepository> _logger;
        private readonly StoreContext _context;

        public MenuRoleRepository(ILogger<MenuRoleRepository> logger, StoreContext context) : base(context)
        {
            _logger = logger;
            _context = context;
        }
    }
}
