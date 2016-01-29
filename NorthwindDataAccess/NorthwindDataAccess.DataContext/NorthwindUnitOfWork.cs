using System.Data.Entity;
using NorthwindDataAccess.Core;
using NorthwindDataAccess.Ef;

namespace NorthwindDataAccess.DataContext
{
    public class NorthwindUnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;

        public NorthwindUnitOfWork()
        {
            _context = new NorthwindContext();
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return new EfRepository<T>(_context);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
