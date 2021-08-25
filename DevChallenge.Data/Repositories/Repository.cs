using DevChallenge.Data.Context;
using DevChallenge.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace DevChallenge.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DataContext _context;
        protected readonly DbSet<T> _dbSet;

        public Repository(DataContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public virtual IQueryable<T> GetAll() => _dbSet.AsNoTracking();

        public virtual async Task<T> GetByIdAsync(object id) => await _dbSet.FindAsync(id);

        public virtual async Task InsertAsync(T entity) => await _dbSet.AddAsync(entity);
        
        public virtual void Update(T entity) => _dbSet.Update(entity);

        public virtual async Task RemoveAsync(object id) => _dbSet.Remove(await _dbSet.FindAsync(id));

        public virtual void SaveChanges() => _context.SaveChanges();

        public virtual async Task SaveChangesAsync() => await _context.SaveChangesAsync();
    }
}