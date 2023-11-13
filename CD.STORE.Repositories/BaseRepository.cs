using CD.STORE.Context;
using CD.STORE.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CD.STORE.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly StoreContext _context;

        public BaseRepository(StoreContext context)
        {
            _context = context;
        }

        public T GetOne(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().SingleOrDefault(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public IQueryable<T> GetAllBy(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }
        public int CountBy(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Count(predicate);
        }

        public IQueryable<T> GetAllNoTracking()
        {
            return _context.Set<T>().AsNoTracking();
        }

        public void Insert(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity), "");
            try
            {
                _context.Entry(entity).State = EntityState.Added;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity), "");
            try
            {
                _context.Entry(entity).State = EntityState.Modified;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Delete(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity), "");
            try
            {
                _context.Entry(entity).State = EntityState.Deleted;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
