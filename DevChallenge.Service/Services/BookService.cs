using DevChallenge.Data.Entities;
using DevChallenge.Data.Repositories.Interfaces;
using DevChallenge.Service.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevChallenge.Service.Services
{
    public class BookService : IBookService
    {
        readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository) =>
            _bookRepository = bookRepository;

        public async Task<IEnumerable<Book>> GetAllBooks() =>
            await _bookRepository.GetAllBooks();

        public async Task<Book> GetBookById(int bookId) =>
            await _bookRepository.GetById(bookId);

        public async Task InsertBook(Book book)
        {
            await _bookRepository.Insert(book);
            await _bookRepository.SaveAsync();
        }
            
        public void UpdateBook(Book book)
        {
            _bookRepository.Update(book);
            _bookRepository.Save();
        }
            
        public async Task RemoveBook(int bookId)
        {
            await _bookRepository.Remove(bookId);
            await _bookRepository.SaveAsync();
        }
            
    }
}
