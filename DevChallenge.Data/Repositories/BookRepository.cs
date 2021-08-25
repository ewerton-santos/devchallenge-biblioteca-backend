using DevChallenge.Data.Entities;
using DevChallenge.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevChallenge.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly IRepository<Book> _repository;

        public BookRepository(IRepository<Book> repository) =>
            _repository = repository;

        public async Task<IEnumerable<Book>> GetAllBooks() =>
            await _repository.GetAll().ToListAsync();

        public async Task<Book> GetById(int bookId) =>
            await _repository.GetByIdAsync(bookId);

        public async Task Insert(Book book) =>
            await _repository.InsertAsync(book);
        
        public void Update(Book book) =>
            _repository.Update(book);

        public async Task Remove(int bookId) =>
            await _repository.RemoveAsync(bookId);

        public void Save() => _repository.SaveChanges();

        public async Task SaveAsync() =>
            await _repository.SaveChangesAsync();
    }
}
