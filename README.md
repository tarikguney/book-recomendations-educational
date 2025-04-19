# 📚 Book Recommendation Website

<div align="center">
  <img src="https://img.shields.io/badge/.NET-9.0-blue" alt=".NET Version">
  <img src="https://img.shields.io/badge/ASP.NET-MVC-green" alt="ASP.NET MVC">
  <img src="https://img.shields.io/badge/Status-Development-yellow" alt="Status">
</div>

## 🌟 Overview

Welcome to the Book Recommendation Website! This project is a modern web application built with .NET 9 and ASP.NET MVC that helps users discover great books through personalized recommendations. The website features a clean, user-friendly interface that showcases book recommendations with detailed information.

## 🎯 Features

- 🏠 Clean, modern homepage with featured book recommendations
- 📖 Detailed book information display
- 🎨 Responsive design that works on all devices
- 📱 Mobile-friendly interface
- 🖼️ Beautiful book card components
- 🔍 Simple and focused user experience

## 🛠️ Prerequisites

Before you begin, ensure you have the following installed:

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Visual Studio 2024](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)
- A modern web browser (Chrome, Firefox, Safari, or Edge)

## 🚀 Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/yourusername/book-recommendation.git
cd book-recommendation
```

### 2. Open the Solution

- If using Visual Studio:
  - Open `BookReco.sln`
  - Wait for the solution to load and restore NuGet packages

- If using Visual Studio Code:
  - Open the project folder
  - Run `dotnet restore` in the terminal

### 3. Build and Run

```bash
dotnet build
dotnet run --project BookReco.Web
```

The application will start, and you can access it at `https://localhost:5001` or `http://localhost:5000`

## 📁 Project Structure

```
BookReco/
├── BookReco.Web/          # Web application (MVC)
├── BookReco.Core/         # Core business logic
└── BookReco.Tests/        # Test project
```

## 🧪 Testing

To run the tests:

```bash
dotnet test
```

## 🔧 Development

### Adding a New Book

The books are stored in `BookReco.Core/Data/books.json`. Each book entry follows this structure:

```json
{
  "id": 46,  // Next available ID
  "title": "Book Title",
  "author": "Author Name",
  "summary": "A brief description of the book",
  "imageUrl": "URL to the book cover image",
  "whyRecommended": "Explanation of why this book is recommended",
  "rating": 4.5,  // Rating out of 5
  "ratingCount": 1000,  // Number of ratings
  "isBookmarked": false  // Default bookmark status
}
```

To add a new book:

1. Open `BookReco.Core/Data/books.json`
2. Add a new entry following the structure above
3. Make sure to:
   - Use the next available ID number
   - Provide a valid image URL
   - Include a compelling summary and recommendation reason
   - Set appropriate rating and rating count values

Example of adding a new book:
```json
{
  "id": 46,
  "title": "Your New Book Title",
  "author": "Author Name",
  "summary": "A compelling summary of the book...",
  "imageUrl": "https://example.com/book-cover.jpg",
  "whyRecommended": "Why this book is valuable to readers...",
  "rating": 4.7,
  "ratingCount": 1500,
  "isBookmarked": false
}
```

### Styling

The project uses modern CSS frameworks for styling. You can find the styles in the `BookReco.Web/wwwroot/css` directory.

## 🤝 Contributing

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 📞 Support

If you encounter any issues or have questions, please open an issue in the GitHub repository.

---

<div align="center">
  <p>Made with ❤️ using .NET 9 and ASP.NET MVC</p>
</div> 