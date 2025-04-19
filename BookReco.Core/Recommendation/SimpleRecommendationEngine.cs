using BookReco.Core.Interfaces;
using BookReco.Core.Models;
using System.Text.Json;
using Microsoft.Extensions.Logging;

namespace BookReco.Core.Recommendation;

public class SimpleRecommendationEngine : IRecommendationEngine
{
    private readonly List<Book> _books;
    private readonly Random _random;
    private readonly ILogger<SimpleRecommendationEngine> _logger;
    private readonly JsonSerializerOptions _jsonOptions;

    public SimpleRecommendationEngine(ILogger<SimpleRecommendationEngine> logger)
    {
        _logger = logger;
        _random = new Random();
        
        _jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        
        try
        {
            var jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "books.json");
            _logger.LogInformation("Attempting to read books from JSON file at: {JsonPath}", jsonPath);
            
            if (!File.Exists(jsonPath))
            {
                _logger.LogError("Books JSON file not found at path: {JsonPath}", jsonPath);
                _books = new List<Book>();
                return;
            }

            var jsonString = File.ReadAllText(jsonPath);
            _logger.LogInformation("Successfully read JSON file. File size: {FileSize} bytes", jsonString.Length);

            _books = JsonSerializer.Deserialize<List<Book>>(jsonString, _jsonOptions);
            
            if (_books == null)
            {
                _logger.LogError("Failed to deserialize books from JSON file");
                _books = new List<Book>();
            }
            else
            {
                _logger.LogInformation("Successfully loaded {BookCount} books from JSON file", _books.Count);
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occurred while loading books from JSON file");
            _books = new List<Book>();
        }
    }

    public IEnumerable<Book> GetAllBooks()
    {
        _logger.LogInformation("Retrieving all books. Total count: {BookCount}", _books.Count);
        return _books;
    }

    public Book GetRandomBook()
    {
        var index = _random.Next(_books.Count);
        var book = _books[index];
        _logger.LogInformation("Retrieved random book: {BookTitle} (ID: {BookId})", book.Title, book.Id);
        return book;
    }

    public Book GetRecommendedBook()
    {
        // For now, we'll just return a random book
        // In a real implementation, this could use various factors to make recommendations
        var book = GetRandomBook();
        _logger.LogInformation("Retrieved recommended book: {BookTitle} (ID: {BookId})", book.Title, book.Id);
        return book;
    }
} 