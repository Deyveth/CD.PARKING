using CD.STORE.Context;
using CD.STORE.Entities.Usm;
using CD.STORE.IApplicationService.Usm;
using CD.STORE.IRepositories.Usm;
using Microsoft.Extensions.Logging;

namespace CD.STORE.ApplicationService.Usm
{
    public class MenuService : IMenuService
    {
        private readonly ILogger<MenuService> _logger;
        private readonly StoreContext _storeContext;
        private readonly IMenuRepository _menuRepository;
        private readonly IUserRepository _userRepository;
        private readonly IMenuRoleRepository _menuRoleRepository;

        public MenuService(ILogger<MenuService> logger, 
                           StoreContext storeContext, 
                           IMenuRepository menuRepository, 
                           IUserRepository userRepository, 
                           IMenuRoleRepository menuRoleRepository)
        {
            _logger = logger;
            _storeContext = storeContext;
            _menuRepository = menuRepository;
            _userRepository = userRepository;
            _menuRoleRepository = menuRoleRepository;
        }

        public List<Menu> GetAllByUser(int userId)
        {
            try
            {
                List<User> user = _userRepository.GetAllBy(x => x.UserId == userId).ToList();
                List<MenuRole> menuRole = _menuRoleRepository.GetAll().ToList();
                List<Menu> menu = _menuRepository.GetAll().ToList();

                List<Menu> result = (from u in user
                                     join mr in menuRole on u.RoleId equals mr.RoleId
                                     join m in menu on mr.MenuId equals m.MenuId
                                     select m).ToList();
                
                return result;

            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex, "");
                throw;
            }
        }
    }
}
