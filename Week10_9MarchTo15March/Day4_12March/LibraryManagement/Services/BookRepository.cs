using LibraryManagement.Models;
namespace LibraryManagement.Services
{
    public class BookRepository : IBookRepository
    {
        private static List<Library> books = new List<Library>()
    {
        new Library{ Id = 1, Title = "C# Basics", Author="John"},
        new Library{ Id = 2, Title = "ASP.NET Core", Author="Smith"},
        new Library{ Id = 3, Title = "Entity Framework", Author="David"}
    };

        public IEnumerable<Library> GetAllBooks()
        {
            return books;
        }

        public Library GetBookById(int id)
        {
            return books.FirstOrDefault(b => b.Id == id);
        }
    }
}
