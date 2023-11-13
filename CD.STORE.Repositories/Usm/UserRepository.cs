using CD.STORE.Context;
using CD.STORE.Entities.Usm;
using CD.STORE.IRepositories.Usm;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CD.STORE.Repositories.Usm
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly ILogger<UserRepository> _logger;
        private readonly StoreContext _context;

        public UserRepository(ILogger<UserRepository> logger, StoreContext context) : base(context)
        {
            _logger = logger;
            _context = context;
        }

        public IQueryable<User> GetAllWithDetails()
        {
            try
            {
                var user = _context.User
                                .Include("Role");
                return user;
            }
            catch (Exception ex)
            {
                _logger.LogInformation("", ex);
                throw;
            }
        }

        public User GetOneWithDetails(string email, string password)
        {
            try
            {
                User user = _context.User
                                .Include("Role")
                                .Where(x => x.Email == email && x.Password == password).FirstOrDefault();
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