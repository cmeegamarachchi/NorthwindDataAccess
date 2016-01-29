using System.Linq;

namespace NorthwindDataAccess.Core
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        T Add(T entity);
    }
}
