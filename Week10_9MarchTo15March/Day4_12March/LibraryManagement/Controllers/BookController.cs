using LibraryManagement.Services;
using Microsoft.AspNetCore.Mvc;

public class BookController : Controller
{
    private readonly IBookRepository _repository;

    public BookController(IBookRepository repository)
    {
        _repository = repository;
    }

    public IActionResult Index()
    {
        var books = _repository.GetAllBooks();
        return View(books);
    }

    public IActionResult Details(int id)
    {
        var book = _repository.GetBookById(id);
        return View(book);
    }
  
}