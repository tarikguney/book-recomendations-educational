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
            },
            new Book
            {
                Id = 5,
                Title = "Refactoring",
                Author = "Martin Fowler",
                Summary = "A comprehensive guide to improving the design of existing code through refactoring techniques.",
                ImageUrl = "https://m.media-amazon.com/images/I/41odjJlPgHL._SX379_BO1,204,203,200_.jpg",
                WhyRecommended = "Learn how to improve code quality without changing its external behavior.",
                Rating = 4.7,
                RatingCount = 2156,
                IsBookmarked = false
            },
            new Book
            {
                Id = 6,
                Title = "Code Complete",
                Author = "Steve McConnell",
                Summary = "A practical handbook of software construction that covers the entire development process.",
                ImageUrl = "https://m.media-amazon.com/images/I/41WfB5he5kL._SX408_BO1,204,203,200_.jpg",
                WhyRecommended = "A comprehensive guide to software development that covers everything from coding to project management.",
                Rating = 4.6,
                RatingCount = 1987,
                IsBookmarked = false
            },
            new Book
            {
                Id = 7,
                Title = "The Clean Coder",
                Author = "Robert C. Martin",
                Summary = "A guide to professional software development practices and principles.",
                ImageUrl = "https://m.media-amazon.com/images/I/41UV5aDZqoL._SX380_BO1,204,203,200_.jpg",
                WhyRecommended = "Learn what it means to be a true software professional.",
                Rating = 4.5,
                RatingCount = 1876,
                IsBookmarked = false
            },
            new Book
            {
                Id = 8,
                Title = "Head First Design Patterns",
                Author = "Eric Freeman, Elisabeth Robson",
                Summary = "A brain-friendly guide to design patterns that makes learning fun and effective.",
                ImageUrl = "https://m.media-amazon.com/images/I/51rmlx5I+iL._SX430_BO1,204,203,200_.jpg",
                WhyRecommended = "A more approachable introduction to design patterns with visual learning techniques.",
                Rating = 4.6,
                RatingCount = 2345,
                IsBookmarked = false
            },
            new Book
            {
                Id = 9,
                Title = "Domain-Driven Design",
                Author = "Eric Evans",
                Summary = "A comprehensive guide to building complex software systems using domain-driven design principles.",
                ImageUrl = "https://m.media-amazon.com/images/I/51OWGtzQLLL._SX380_BO1,204,203,200_.jpg",
                WhyRecommended = "Essential reading for understanding how to model complex business domains in software.",
                Rating = 4.5,
                RatingCount = 1987,
                IsBookmarked = false
            },
            new Book
            {
                Id = 10,
                Title = "Working Effectively with Legacy Code",
                Author = "Michael Feathers",
                Summary = "A practical guide to dealing with legacy code and making it more maintainable.",
                ImageUrl = "https://m.media-amazon.com/images/I/51HqvYQPj5L._SX380_BO1,204,203,200_.jpg",
                WhyRecommended = "Learn techniques for safely modifying and improving legacy code.",
                Rating = 4.6,
                RatingCount = 1876,
                IsBookmarked = false
            },
            new Book
            {
                Id = 11,
                Title = "Test-Driven Development",
                Author = "Kent Beck",
                Summary = "A guide to test-driven development practices that help create more reliable software.",
                ImageUrl = "https://m.media-amazon.com/images/I/51kDbV%2BN65L._SX379_BO1,204,203,200_.jpg",
                WhyRecommended = "Master the art of writing tests first and creating more maintainable code.",
                Rating = 4.5,
                RatingCount = 1765,
                IsBookmarked = false
            },
            new Book
            {
                Id = 12,
                Title = "Continuous Delivery",
                Author = "Jez Humble, David Farley",
                Summary = "A guide to building, testing, and deploying software more reliably and frequently.",
                ImageUrl = "https://m.media-amazon.com/images/I/41kzqWjq+wL._SX379_BO1,204,203,200_.jpg",
                WhyRecommended = "Learn how to build a reliable and efficient software delivery pipeline.",
                Rating = 4.7,
                RatingCount = 1987,
                IsBookmarked = false
            },
            new Book
            {
                Id = 13,
                Title = "The Phoenix Project",
                Author = "Gene Kim, Kevin Behr, George Spafford",
                Summary = "A novel about IT, DevOps, and helping your business win.",
                ImageUrl = "https://m.media-amazon.com/images/I/51WIKil9YvL._SX331_BO1,204,203,200_.jpg",
                WhyRecommended = "A compelling story that teaches important lessons about DevOps and IT management.",
                Rating = 4.6,
                RatingCount = 2345,
                IsBookmarked = false
            },
            new Book
            {
                Id = 14,
                Title = "Site Reliability Engineering",
                Author = "Betsy Beyer, Chris Jones, Jennifer Petoff, Niall Richard Murphy",
                Summary = "How Google runs production systems.",
                ImageUrl = "https://m.media-amazon.com/images/I/41WfB5he5kL._SX408_BO1,204,203,200_.jpg",
                WhyRecommended = "Learn how Google manages its production systems at scale.",
                Rating = 4.7,
                RatingCount = 1987,
                IsBookmarked = false
            },
            new Book
            {
                Id = 15,
                Title = "Building Microservices",
                Author = "Sam Newman",
                Summary = "Designing fine-grained systems.",
                ImageUrl = "https://m.media-amazon.com/images/I/41kzqWjq+wL._SX379_BO1,204,203,200_.jpg",
                WhyRecommended = "A comprehensive guide to building and managing microservices architectures.",
                Rating = 4.6,
                RatingCount = 1876,
                IsBookmarked = false
            },
            new Book
            {
                Id = 16,
                Title = "Release It!",
                Author = "Michael Nygard",
                Summary = "Design and deploy production-ready software.",
                ImageUrl = "https://m.media-amazon.com/images/I/51WIKil9YvL._SX331_BO1,204,203,200_.jpg",
                WhyRecommended = "Learn how to design systems that are resilient in production.",
                Rating = 4.5,
                RatingCount = 1765,
                IsBookmarked = false
            },
            new Book
            {
                Id = 17,
                Title = "The Art of Unit Testing",
                Author = "Roy Osherove",
                Summary = "With examples in C#.",
                ImageUrl = "https://m.media-amazon.com/images/I/51kDbV%2BN65L._SX379_BO1,204,203,200_.jpg",
                WhyRecommended = "A practical guide to writing effective unit tests.",
                Rating = 4.4,
                RatingCount = 1654,
                IsBookmarked = false
            },
            new Book
            {
                Id = 18,
                Title = "Patterns of Enterprise Application Architecture",
                Author = "Martin Fowler",
                Summary = "A guide to enterprise application architecture patterns.",
                ImageUrl = "https://m.media-amazon.com/images/I/51szD9HC9pL._SX395_BO1,204,203,200_.jpg",
                WhyRecommended = "Learn patterns for building enterprise applications.",
                Rating = 4.6,
                RatingCount = 1987,
                IsBookmarked = false
            },
            new Book
            {
                Id = 19,
                Title = "Refactoring to Patterns",
                Author = "Joshua Kerievsky",
                Summary = "A guide to refactoring code to use design patterns.",
                ImageUrl = "https://m.media-amazon.com/images/I/41odjJlPgHL._SX379_BO1,204,203,200_.jpg",
                WhyRecommended = "Learn how to evolve your code towards better design patterns.",
                Rating = 4.5,
                RatingCount = 1876,
                IsBookmarked = false
            },
            new Book
            {
                Id = 20,
                Title = "Growing Object-Oriented Software, Guided by Tests",
                Author = "Steve Freeman, Nat Pryce",
                Summary = "A guide to test-driven development in practice.",
                ImageUrl = "https://m.media-amazon.com/images/I/51rmlx5I+iL._SX430_BO1,204,203,200_.jpg",
                WhyRecommended = "Learn how to grow software using TDD principles.",
                Rating = 4.6,
                RatingCount = 1765,
                IsBookmarked = false
            },
            new Book
            {
                Id = 21,
                Title = "The Mythical Man-Month",
                Author = "Frederick P. Brooks Jr.",
                Summary = "Essays on software engineering.",
                ImageUrl = "https://m.media-amazon.com/images/I/51OWGtzQLLL._SX380_BO1,204,203,200_.jpg",
                WhyRecommended = "Classic essays on software project management.",
                Rating = 4.5,
                RatingCount = 1987,
                IsBookmarked = false
            },
            new Book
            {
                Id = 22,
                Title = "Peopleware",
                Author = "Tom DeMarco, Timothy Lister",
                Summary = "Productive projects and teams.",
                ImageUrl = "https://m.media-amazon.com/images/I/51HqvYQPj5L._SX380_BO1,204,203,200_.jpg",
                WhyRecommended = "Learn about managing software teams effectively.",
                Rating = 4.6,
                RatingCount = 1876,
                IsBookmarked = false
            },
            new Book
            {
                Id = 23,
                Title = "The DevOps Handbook",
                Author = "Gene Kim, Jez Humble, Patrick Debois, John Willis",
                Summary = "How to create world-class agility, reliability, and security in technology organizations.",
                ImageUrl = "https://m.media-amazon.com/images/I/51WIKil9YvL._SX331_BO1,204,203,200_.jpg",
                WhyRecommended = "A comprehensive guide to implementing DevOps practices.",
                Rating = 4.7,
                RatingCount = 1987,
                IsBookmarked = false
            },
            new Book
            {
                Id = 24,
                Title = "Accelerate",
                Author = "Nicole Forsgren, Jez Humble, Gene Kim",
                Summary = "The science of lean software and DevOps.",
                ImageUrl = "https://m.media-amazon.com/images/I/41kzqWjq+wL._SX379_BO1,204,203,200_.jpg",
                WhyRecommended = "Learn about the science behind high-performing technology organizations.",
                Rating = 4.6,
                RatingCount = 1876,
                IsBookmarked = false
            },
            new Book
            {
                Id = 25,
                Title = "The Unicorn Project",
                Author = "Gene Kim",
                Summary = "A novel about developers, digital disruption, and surviving the future.",
                ImageUrl = "https://m.media-amazon.com/images/I/51WIKil9YvL._SX331_BO1,204,203,200_.jpg",
                WhyRecommended = "A sequel to The Phoenix Project that focuses on developers and digital transformation.",
                Rating = 4.5,
                RatingCount = 1765,
                IsBookmarked = false
            },
            new Book
            {
                Id = 26,
                Title = "Continuous Integration",
                Author = "Paul M. Duvall",
                Summary = "Improving software quality and reducing risk.",
                ImageUrl = "https://m.media-amazon.com/images/I/41kzqWjq+wL._SX379_BO1,204,203,200_.jpg",
                WhyRecommended = "Learn how to implement continuous integration effectively.",
                Rating = 4.4,
                RatingCount = 1654,
                IsBookmarked = false
            },
            new Book
            {
                Id = 27,
                Title = "The Art of Readable Code",
                Author = "Dustin Boswell, Trevor Foucher",
                Summary = "Simple and practical techniques for writing better code.",
                ImageUrl = "https://m.media-amazon.com/images/I/51kDbV%2BN65L._SX379_BO1,204,203,200_.jpg",
                WhyRecommended = "Learn how to write code that is easy to understand and maintain.",
                Rating = 4.5,
                RatingCount = 1987,
                IsBookmarked = false
            },
            new Book
            {
                Id = 28,
                Title = "Refactoring Databases",
                Author = "Scott W. Ambler, Pramod J. Sadalage",
                Summary = "Evolutionary database design.",
                ImageUrl = "https://m.media-amazon.com/images/I/41odjJlPgHL._SX379_BO1,204,203,200_.jpg",
                WhyRecommended = "Learn how to evolve database schemas safely.",
                Rating = 4.4,
                RatingCount = 1876,
                IsBookmarked = false
            },
            new Book
            {
                Id = 29,
                Title = "The Clean Architecture",
                Author = "Robert C. Martin",
                Summary = "A craftsman's guide to software structure and design.",
                ImageUrl = "https://m.media-amazon.com/images/I/41UV5aDZqoL._SX380_BO1,204,203,200_.jpg",
                WhyRecommended = "Learn about clean architecture principles and practices.",
                Rating = 4.6,
                RatingCount = 1765,
                IsBookmarked = false
            },
            new Book
            {
                Id = 30,
                Title = "Implementing Domain-Driven Design",
                Author = "Vaughn Vernon",
                Summary = "A practical guide to implementing DDD.",
                ImageUrl = "https://m.media-amazon.com/images/I/51OWGtzQLLL._SX380_BO1,204,203,200_.jpg",
                WhyRecommended = "Learn how to implement DDD in real-world applications.",
                Rating = 4.5,
                RatingCount = 1987,
                IsBookmarked = false
            },
            new Book
            {
                Id = 31,
                Title = "The Software Craftsman",
                Author = "Sandro Mancuso",
                Summary = "Professionalism, pragmatism, pride.",
                ImageUrl = "https://m.media-amazon.com/images/I/51HqvYQPj5L._SX380_BO1,204,203,200_.jpg",
                WhyRecommended = "Learn about software craftsmanship and professional development.",
                Rating = 4.6,
                RatingCount = 1876,
                IsBookmarked = false
            },
            new Book
            {
                Id = 32,
                Title = "Extreme Programming Explained",
                Author = "Kent Beck",
                Summary = "Embrace change.",
                ImageUrl = "https://m.media-amazon.com/images/I/51kDbV%2BN65L._SX379_BO1,204,203,200_.jpg",
                WhyRecommended = "Learn about extreme programming practices and principles.",
                Rating = 4.5,
                RatingCount = 1765,
                IsBookmarked = false
            },
            new Book
            {
                Id = 33,
                Title = "Agile Software Development",
                Author = "Robert C. Martin",
                Summary = "Principles, patterns, and practices.",
                ImageUrl = "https://m.media-amazon.com/images/I/41UV5aDZqoL._SX380_BO1,204,203,200_.jpg",
                WhyRecommended = "Learn about agile software development principles and practices.",
                Rating = 4.6,
                RatingCount = 1987,
                IsBookmarked = false
            },
            new Book
            {
                Id = 34,
                Title = "The Art of Agile Development",
                Author = "James Shore",
                Summary = "A practical guide to agile software development.",
                ImageUrl = "https://m.media-amazon.com/images/I/51WIKil9YvL._SX331_BO1,204,203,200_.jpg",
                WhyRecommended = "Learn practical agile development techniques.",
                Rating = 4.5,
                RatingCount = 1876,
                IsBookmarked = false
            },
            new Book
            {
                Id = 35,
                Title = "User Stories Applied",
                Author = "Mike Cohn",
                Summary = "For agile software development.",
                ImageUrl = "https://m.media-amazon.com/images/I/41kzqWjq+wL._SX379_BO1,204,203,200_.jpg",
                WhyRecommended = "Learn how to write effective user stories.",
                Rating = 4.4,
                RatingCount = 1765,
                IsBookmarked = false
            },
            new Book
            {
                Id = 36,
                Title = "Agile Estimating and Planning",
                Author = "Mike Cohn",
                Summary = "A practical guide to agile project management.",
                ImageUrl = "https://m.media-amazon.com/images/I/41kzqWjq+wL._SX379_BO1,204,203,200_.jpg",
                WhyRecommended = "Learn how to estimate and plan agile projects effectively.",
                Rating = 4.5,
                RatingCount = 1987,
                IsBookmarked = false
            },
            new Book
            {
                Id = 37,
                Title = "Scrum: The Art of Doing Twice the Work in Half the Time",
                Author = "Jeff Sutherland",
                Summary = "A guide to implementing Scrum effectively.",
                ImageUrl = "https://m.media-amazon.com/images/I/51WIKil9YvL._SX331_BO1,204,203,200_.jpg",
                WhyRecommended = "Learn about Scrum from one of its creators.",
                Rating = 4.6,
                RatingCount = 1876,
                IsBookmarked = false
            },
            new Book
            {
                Id = 38,
                Title = "Lean Software Development",
                Author = "Mary Poppendieck, Tom Poppendieck",
                Summary = "An agile toolkit.",
                ImageUrl = "https://m.media-amazon.com/images/I/41kzqWjq+wL._SX379_BO1,204,203,200_.jpg",
                WhyRecommended = "Learn how to apply lean principles to software development.",
                Rating = 4.5,
                RatingCount = 1765,
                IsBookmarked = false
            },
            new Book
            {
                Id = 39,
                Title = "Kanban",
                Author = "David J. Anderson",
                Summary = "Successful evolutionary change for your technology business.",
                ImageUrl = "https://m.media-amazon.com/images/I/51WIKil9YvL._SX331_BO1,204,203,200_.jpg",
                WhyRecommended = "Learn how to implement Kanban in your organization.",
                Rating = 4.4,
                RatingCount = 1654,
                IsBookmarked = false
            },
            new Book
            {
                Id = 40,
                Title = "The Lean Startup",
                Author = "Eric Ries",
                Summary = "How today's entrepreneurs use continuous innovation to create radically successful businesses.",
                ImageUrl = "https://m.media-amazon.com/images/I/41kzqWjq+wL._SX379_BO1,204,203,200_.jpg",
                WhyRecommended = "Learn how to apply lean principles to startup development.",
                Rating = 4.6,
                RatingCount = 1987,
                IsBookmarked = false
            },
            new Book
            {
                Id = 41,
                Title = "The Lean Product Playbook",
                Author = "Dan Olsen",
                Summary = "How to innovate with minimum viable products and rapid customer feedback.",
                ImageUrl = "https://m.media-amazon.com/images/I/51WIKil9YvL._SX331_BO1,204,203,200_.jpg",
                WhyRecommended = "Learn how to build successful products using lean principles.",
                Rating = 4.5,
                RatingCount = 1876,
                IsBookmarked = false
            },
            new Book
            {
                Id = 42,
                Title = "Inspired",
                Author = "Marty Cagan",
                Summary = "How to create products customers love.",
                ImageUrl = "https://m.media-amazon.com/images/I/41kzqWjq+wL._SX379_BO1,204,203,200_.jpg",
                WhyRecommended = "Learn how to build successful products from a product management expert.",
                Rating = 4.6,
                RatingCount = 1765,
                IsBookmarked = false
            },
            new Book
            {
                Id = 43,
                Title = "The Product Book",
                Author = "Product School",
                Summary = "How to become a great product manager.",
                ImageUrl = "https://m.media-amazon.com/images/I/51WIKil9YvL._SX331_BO1,204,203,200_.jpg",
                WhyRecommended = "A comprehensive guide to product management.",
                Rating = 4.5,
                RatingCount = 1987,
                IsBookmarked = false
            },
            new Book
            {
                Id = 44,
                Title = "Hooked",
                Author = "Nir Eyal",
                Summary = "How to build habit-forming products.",
                ImageUrl = "https://m.media-amazon.com/images/I/41kzqWjq+wL._SX379_BO1,204,203,200_.jpg",
                WhyRecommended = "Learn how to create products that users can't put down.",
                Rating = 4.4,
                RatingCount = 1876,
                IsBookmarked = false
            },
            new Book
            {
                Id = 45,
                Title = "Insurance Tech Patterns: Best Practices for Developers",
                Author = "John Doe",
                Summary = "A comprehensive guide to building insurance technology systems using modern software development practices.",
                ImageUrl = "https://m.media-amazon.com/images/I/51WIKil9YvL._SX331_BO1,204,203,200_.jpg",
                WhyRecommended = "Essential reading for developers working in the insurance industry, covering patterns and best practices specific to insurance technology.",
                Rating = 4.7,
                RatingCount = 2156,
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