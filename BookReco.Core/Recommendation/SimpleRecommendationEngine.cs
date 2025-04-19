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
                WhyRecommended = "This book is a timeless classic that every developer should read. It provides practical advice and wisdom that remains relevant regardless of the technology stack you're working with."
            },
            new Book
            {
                Id = 2,
                Title = "Clean Code",
                Author = "Robert C. Martin",
                Summary = "A handbook of agile software craftsmanship that teaches you how to write clean, maintainable code.",
                ImageUrl = "https://m.media-amazon.com/images/I/41xShlnTZTL._SX376_BO1,204,203,200_.jpg",
                WhyRecommended = "This book fundamentally changed how many developers think about writing code. It's filled with practical examples and principles that will make you a better programmer."
            },
            new Book
            {
                Id = 3,
                Title = "Designing Data-Intensive Applications",
                Author = "Martin Kleppmann",
                Summary = "The big ideas behind reliable, scalable, and maintainable systems.",
                ImageUrl = "https://m.media-amazon.com/images/P/1449373321.01._SCLZZZZZZZ_SX500_.jpg",
                WhyRecommended = "An essential read for understanding the fundamentals of building scalable systems. It covers everything from databases to distributed systems in a clear, comprehensive way."
            },
            new Book
            {
                Id = 4,
                Title = "Refactoring",
                Author = "Martin Fowler",
                Summary = "Improving the design of existing code through proven techniques and patterns.",
                ImageUrl = "https://m.media-amazon.com/images/I/41odjJlPgHL._SX379_BO1,204,203,200_.jpg",
                WhyRecommended = "This book provides a catalog of refactoring techniques that help you improve your code without changing its external behavior. It's a must-read for maintaining healthy codebases."
            },
            new Book
            {
                Id = 5,
                Title = "Domain-Driven Design",
                Author = "Eric Evans",
                Summary = "Tackling complexity in the heart of software by focusing on the core domain and domain logic.",
                ImageUrl = "https://m.media-amazon.com/images/I/51OWGtzQLLL._SX379_BO1,204,203,200_.jpg",
                WhyRecommended = "This book introduces powerful concepts for modeling complex business domains. It's particularly valuable for building enterprise applications with rich domain models."
            }
        };
    }

    public Book GetRecommendedBook()
    {
        int index = _random.Next(_books.Count);
        return _books[index];
    }

    public IEnumerable<Book> GetAllBooks()
    {
        return _books;
    }
} 