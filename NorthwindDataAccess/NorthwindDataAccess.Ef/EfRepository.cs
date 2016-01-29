using System.Data.Entity;
using System.Linq;
using NorthwindDataAccess.Core;

namespace NorthwindDataAccess.Ef
{
    public class EfRepository<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> _set;

        public EfRepository(DbContext context)
        {
            _set = context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return _set;
        }

        public T Add(T entity)
        {
            return _set.Add(entity);
        }
    }
}
