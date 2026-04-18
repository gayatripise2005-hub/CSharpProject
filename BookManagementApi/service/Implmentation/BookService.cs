
using BookManagementApi.Entity;
using BookManagementApi.Repository;
using BookManagementApi.service.Definition;

namespace BookManagementApi.service.Implmentation
{
    public class BookService : IBookService
    {
        private readonly IRepository<Book> _repository;

        
        public BookService(IRepository<Book> repository)
        {
            _repository = repository;
        }

        public async Task<List<Book>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<Book> GetById(int id)
        {
            var book = await _repository.GetById(id);

            if (book == null)
                throw new Exception("Book not found");

            return book;
        }

        public async Task<Book> Add(Book book)
        {
            if (book == null)
                throw new Exception("Invalid Book");

            if (string.IsNullOrWhiteSpace(book.Title))
                throw new ArgumentException("Title is required");

            if (string.IsNullOrWhiteSpace(book.Author))
                throw new ArgumentException("Author is required");

            if (book.Price <= 0)
                throw new ArgumentException("Price must be greater than zero");

            await _repository.Add(book);
            return book;
        }

        public async Task<Book> Update(Book book)
        {
            if (book == null)
                throw new Exception("Invalid Book");

            var existing = await _repository.GetById(book.Id);

            if (existing == null)
                throw new Exception("Book not found");

            await _repository.Update(book);
            return book;
        }

        public async Task<bool> Delete(int id)
        {
            var existing = await _repository.GetById(id);

            if (existing == null)
                throw new Exception("Book not found");

            await _repository.Delete(id);
            return true;
        }
    }
}
