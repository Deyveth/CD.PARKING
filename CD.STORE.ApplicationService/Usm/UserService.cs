using CD.STORE.Context;
using CD.STORE.Entities.Usm;
using CD.STORE.IApplicationService.Usm;
using CD.STORE.IRepositories.Usm;
using Microsoft.Extensions.Logging;

namespace CD.STORE.ApplicationService.Usm
{
    public class UserService : IUserService
    {
        private readonly ILogger<UserService> _logger;
        private readonly StoreContext _context;
        private readonly IUserRepository _userRepository;

        public UserService(ILogger<UserService> logger, StoreContext context, IUserRepository userRepository)
        {
            _logger = logger;
            _context = context;
            _userRepository = userRepository;
        }

        public User GetOne(int id)
        {
            try
            {
                User response = _userRepository.GetOne(x => x.UserId == id);
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

        public List<User> GetAllWithDetails()
        {
            try
            {
                List<User> response = _userRepository.GetAllWithDetails().ToList();
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

        public User ValidateUser(string email, string password)
        {
            try
            {
                User response = _userRepository.GetOneWithDetails(email, password);
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

        public User Save(User user)
        {
            try
            {
                if (user.UserId == 0)
                    _userRepository.Insert(user);
                else
                    _userRepository.Update(user);
                    

                _context.SaveChanges();

                return user;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }
        public User Delete(User user)
        {
            try
            {
                _userRepository.Delete(user);
                _context.SaveChanges();

                return user;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }
    }
}