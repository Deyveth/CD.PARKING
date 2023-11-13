using System.Linq.Expressions;

namespace CD.STORE.IRepositories
{
    public interface IBaseRepository<T>
    {
        T GetOne(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll();
        IQueryable<T> GetAllBy(Expression<Func<T, bool>> predicate);
        int CountBy(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAllNoTracking();
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
