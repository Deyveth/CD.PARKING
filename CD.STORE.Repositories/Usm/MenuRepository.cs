using CD.STORE.Context;
using CD.STORE.Entities.Usm;
using CD.STORE.IRepositories.Usm;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CD.STORE.Repositories.Usm
{
    public class MenuRepository : BaseRepository<Menu>, IMenuRepository
    {
        private readonly ILogger<MenuRepository> _logger;
        private readonly StoreContext _context;

        public MenuRepository(ILogger<MenuRepository> logger, StoreContext context) : base(context)
        {
            _logger = logger;
            _context = context;
        }

        public IQueryable<Menu> GetAllWithDetails()
        {
            try
            {
                var user = _context.Menu
                                .Include("Role");
                return user;
            }
            catch (Exception ex)
            {
                _logger.LogInformation("", ex);
                throw;
            }
        }
    }
}
