using CD.STORE.Entities.Usm;

namespace CD.STORE.IApplicationService.Usm
{
    public interface IMenuService
    {
        List<Menu> GetAllByUser(int userId);
    }
}
