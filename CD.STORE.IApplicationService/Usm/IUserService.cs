using CD.STORE.Entities.Usm;

namespace CD.STORE.IApplicationService.Usm
{
    public interface IUserService
    {
        User GetOne(int id);
        List<User> GetAllWithDetails();
        User Save(User user);
        User ValidateUser(string email, string password);
        User Delete(User user);
    }
}