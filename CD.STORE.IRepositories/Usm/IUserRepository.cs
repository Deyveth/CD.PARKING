using CD.STORE.Entities.Usm;

namespace CD.STORE.IRepositories.Usm
{
    public interface IUserRepository : IBaseRepository<User>
    {
        IQueryable<User> GetAllWithDetails();
        User GetOneWithDetails(string email, string password);
    }
}