using LibraryManagement.Models;

namespace LibraryManagement.Services
{
    public interface  IBookRepository
    {
       
            IEnumerable<Library> GetAllBooks();
            Library GetBookById(int id);
        }
    
}
