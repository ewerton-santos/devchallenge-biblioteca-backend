using DevChallenge.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevChallenge.Data.Repositories.Interfaces
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllBooks();
        Task<Book> GetById(int bookId);
        Task Insert(Book book);
        void Update(Book book);
        Task Remove(int bookId);
        void Save();
        Task SaveAsync();
    }
}