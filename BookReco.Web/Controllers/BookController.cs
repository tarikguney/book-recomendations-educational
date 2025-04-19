using BookReco.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookReco.Web.Controllers;

public class BookController : Controller
{
    private readonly IRecommendationEngine _recommendationEngine;

    public BookController(IRecommendationEngine recommendationEngine)
    {
        _recommendationEngine = recommendationEngine;
    }

    public IActionResult Index()
    {
        var books = _recommendationEngine.GetAllBooks();
        return View(books);
    }

    public IActionResult Details(int id)
    {
        var book = _recommendationEngine.GetAllBooks().FirstOrDefault(b => b.Id == id);
        if (book == null)
        {
            return NotFound();
        }
        return View(book);
    }
} 