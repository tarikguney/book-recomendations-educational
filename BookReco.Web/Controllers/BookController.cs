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
        var recommendedBook = _recommendationEngine.GetRecommendedBook();
        return View(recommendedBook);
    }

    public IActionResult Details(int id)
    {
        var book = _recommendationEngine.GetRecommendedBook();
        if (book.Id != id)
        {
            return NotFound();
        }
        return View(book);
    }
} 