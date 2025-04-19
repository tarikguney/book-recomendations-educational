using BookReco.Core.Interfaces;
using BookReco.Core.Models;

namespace BookReco.Core.Recommendation;

public class SimpleRecommendationEngine : IRecommendationEngine
{
    private readonly List<Book> _books;
    private readonly Random _random;

    public SimpleRecommendationEngine()
    {
        _random = new Random();
        _books = new List<Book>
        {
            new Book
            {
                Id = 1,
                Title = "The Pragmatic Programmer",
                Author = "Andrew Hunt and David Thomas",
                Summary = "A guide to software development best practices that helps programmers become more effective and efficient.",
                ImageUrl = "https://m.media-amazon.com/images/I/51W1sBPO7tL._SX380_BO1,204,203,200_.jpg",
                WhyRecommended = "This book is a timeless classic that every developer should read. It provides practical advice and wisdom that remains relevant regardless of the technology stack you're working with.",
                Rating = 4.7,
                RatingCount = 3842,
                IsBookmarked = false
            },
            new Book
            {
                Id = 2,
                Title = "Clean Code",
                Author = "Robert C. Martin",
                Summary = "A handbook of agile software craftsmanship that teaches you how to write clean, maintainable code.",
                ImageUrl = "https://m.media-amazon.com/images/I/41xShlnTZTL._SX376_BO1,204,203,200_.jpg",
                WhyRecommended = "This book fundamentally changed how many developers think about writing code. It's filled with practical examples and principles that will make you a better programmer.",
                Rating = 4.8,
                RatingCount = 5231,
                IsBookmarked = false
            },
            new Book
            {
                Id = 3,
                Title = "Design Patterns",
                Author = "Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides",
                Summary = "The definitive guide to software design patterns, introducing timeless solutions to common problems in software design.",
                ImageUrl = "https://m.media-amazon.com/images/I/51szD9HC9pL._SX395_BO1,204,203,200_.jpg",
                WhyRecommended = "Known as the 'Gang of Four' book, this is the foundational text for understanding design patterns in object-oriented programming.",
                Rating = 4.6,
                RatingCount = 2947,
                IsBookmarked = false
            },
            new Book
            {
                Id = 4,
                Title = "Designing Data-Intensive Applications",
                Author = "Martin Kleppmann",
                Summary = "A deep dive into the principles and practices of building robust, scalable data systems.",
                ImageUrl = "https://m.media-amazon.com/images/I/51ZSpMl1-LL._SX379_BO1,204,203,200_.jpg",
                WhyRecommended = "Essential reading for anyone working with distributed systems or large-scale data applications.",
                Rating = 4.9,
                RatingCount = 4521,
                IsBookmarked = false
            }
        };
    }

    public IEnumerable<Book> GetAllBooks()
    {
        return _books;
    }

    public Book GetRandomBook()
    {
        var index = _random.Next(_books.Count);
        return _books[index];
    }

    public Book GetRecommendedBook()
    {
        // For now, we'll just return a random book
        // In a real implementation, this could use various factors to make recommendations
        return GetRandomBook();
    }
} 