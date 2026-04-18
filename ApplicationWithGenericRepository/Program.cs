

using ApplicationWithGenericRepository.Data;
using ApplicationWithGenericRepository.Entity.Liabary;
using ApplicationWithGenericRepository.Repositories.Defination;
using ApplicationWithGenericRepository.Repositories.Implementation;

public class Program 
{
    /// <summary>
    /// Add books to the database using the generic repository pattern. This method validates the input and ensures that the book and context are not null before attempting to create a new book record in the database. It also provides feedback on the success or failure of the operation.
    /// </summary>
    /// <param name="book"></param>
    /// <param name="context"></param>
    /// <returns> </returns>
    public static async  Task  AddBook(Book book,AppDbContext context)
    {
        if (book == null)
        {
            Console.WriteLine("Book cannot be null.");
            return;
        }
        if(string.IsNullOrWhiteSpace(book.Name) || string.IsNullOrWhiteSpace(book.Author))
        {
            Console.WriteLine("Book name and author cannot be empty.");
            return;
        }
        if (context == null)
        {
            Console.WriteLine("Database context cannot be null.");
            return;
        }
        IRepository<Book> _bookRepository = new Repository<Book>(context);
        var entity = await _bookRepository.CreateAsync(book);
        if (entity != null)
        {
            Console.WriteLine($"Book created successfully with Id: {entity.Id}");
        }
        else
        {
            Console.WriteLine("Failed to create book.");
        }   
    }

    /// <summary>
    /// Delete a book from the database using the generic repository pattern. This method checks if the book and context are valid before attempting to delete the book record. It also provides feedback on whether the deletion was successful or if any issues were encountered.
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    /// 
    public static async Task DeleteBook(int bookId, AppDbContext context)
    {
        if (bookId <= 0)
        {
            Console.WriteLine("Invalid book ID.");
            return;
        }
        if (context == null)
        {
            Console.WriteLine("Database context cannot be null.");
            return;
        }
        IRepository<Book> _bookRepository = new Repository<Book>(context);
        var book = await _bookRepository.GetByIdAsync(bookId);
        if (book == null)
        {
            Console.WriteLine($"No book found with ID: {bookId}");
            return;
        }
        bool isDeleted = await _bookRepository.DeleteAsync(book);
        if (isDeleted)
        {
            Console.WriteLine($"Book with ID: {bookId} deleted successfully.");
        }
        else
        {
            Console.WriteLine($"Failed to delete book with ID: {bookId}.");
        }
    }
    public static async Task Main(string[] args)
    {
        //its Console application to test the generic repository pattern
        AppDbContext context = new AppDbContext();
            var book = new Book
            {
                Name = "The Great Gatsby",
                Author = "F. Scott Fitzgerald"
            };
       await AddBook(book, context);

    }
}