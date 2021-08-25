using DevChallenge.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace DevChallenge.Service.Services.Interfaces
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAllBooks();
        Task<Book> GetBookById(int bookId);
        Task InsertBook(Book book);
        void UpdateBook(Book book);
        Task RemoveBook(int bookId);        
    }
}