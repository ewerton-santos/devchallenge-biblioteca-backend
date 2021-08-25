using System.Linq;
using System.Threading.Tasks;

namespace DevChallenge.Data.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        Task<T> GetByIdAsync(object id);
        Task InsertAsync(T entity);
        void Update(T entity);
        Task RemoveAsync(object id);
        void SaveChanges();
        Task SaveChangesAsync();
    }
}