using BookManagementApi.Entity;

namespace BookManagementApi.service.Definition
{
    public interface IBookService
    {
        Task<List<Book>> GetAll();
        Task<Book> GetById(int id);
        Task<Book> Add(Book book);
        Task<Book> Update(Book book);
        Task<bool> Delete(int id);
    }
}
