# 📘 Book Recommendation Website – Development Plan

This document outlines the full development plan for building a **book recommendation website** using **.NET 9 ASP.NET MVC**. It is structured to be AI-agent friendly and used with tools like **Cursor**.

> 🚫 **NOTE:** This plan is dedicated to planning only. No code or files should be generated unless explicitly defined. We will use separate threads for implementation phases to avoid context drift.

---

## ✅ Project Goal

Build a **book recommendation website** that:

- Shows a recommended book on the homepage
- Displays book **image**, **title**, **summary**, and **why it is recommended**
- Uses **compelling visual elements** for modern UX
- Is implemented using **.NET 9 ASP.NET MVC**
- Is modular and extensible for future features (e.g., AI-generated recommendations)

---

## 📌 Project Phases and Milestones

### 🧱 Phase 1: Architecture & Planning
- Define user journey and main UI pages
- Specify static vs. dynamic content
- Choose rendering strategy: MVC views
- Identify optional backend features (e.g., admin input, AI summaries)

### 🔧 Phase 2: Tooling Setup
- Initialize a .NET 9 MVC project
- Create a structured solution layout with multiple projects:
  - Web (UI)
  - Core (Models/Logic)
  - Tests (Unit/Integration)
- Add TailwindCSS or Bootstrap for styling
- Set up logging (e.g., Serilog) and dependency injection

### 🔍 Phase 3: Core Features
- Display a recommended book on the homepage
- Each book includes: image, title, author, summary, "why it's recommended"
- Optional detail page if user clicks on a book
- Admin method or config-based approach to input books (start with hardcoded or JSON)
- Build a recommendation engine stub (strategy pattern to support future AI logic)

### 🎨 Phase 4: UI/UX Design
- Integrate TailwindCSS (preferred) or Bootstrap 5
- Use card layout for book display
- Ensure layout is mobile-friendly and responsive
- Add subtle transitions and hover states

### 🔗 Phase 5: Data & Integration
- Store book data in JSON or in-memory list (no database for now)
- Support static or uploaded book images
- Keep image hosting simple (e.g., `/wwwroot/assets`)

### ✅ Phase 6: Testing & QA
- Unit test recommendation logic and controller actions
- Integration test basic routing
- Manual validation of UI on multiple devices and browsers

### 🚀 Phase 7: CI/CD Pipeline
- Add GitHub Actions or Azure DevOps pipeline
- Build + Test steps
- Optional deployment to Azure App Service

---

## 🧬 Core Modules & Components

- `BookModel`: Represents a book with properties (Title, Author, Summary, ImageUrl, WhyRecommended)
- `BookController`: Handles routing and populates the view model
- `BookViewModel`: Tailored data for the UI
- `RecommendationEngine`: Selects or returns a book (simple version now, pluggable for future)
- `BookRepository`: Data source for books (JSON or in-memory for now)

---

## ⚙️ Tools, Frameworks, Dependencies

- `.NET 9` ASP.NET MVC (no Razor Pages unless specified)
- `TailwindCSS` (preferred) or `Bootstrap 5`
- `Serilog` for structured logging
- `xUnit` or `NUnit` for unit testing
- Optional: `FluentValidation`, Swagger, AI SDKs (future)

---

## 📁 Suggested Folder Structure

```
/BookReco/
│
├── BookReco.Web/                  # ASP.NET MVC frontend project
│   ├── Controllers/
│   ├── Views/
│   │   └── Shared/
│   ├── wwwroot/
│   │   ├── css/
│   │   ├── js/
│   │   └── assets/                # Static book images
│   ├── Models/                    # View-specific models
│   ├── ViewModels/
│   ├── Services/                  # UI-layer services
│   └── appsettings.json
│
├── BookReco.Core/                 # Business/domain logic
│   ├── Models/                    # BookModel, etc.
│   ├── Interfaces/
│   ├── Recommendation/           # RecommendationEngine logic
│
├── BookReco.Tests/                # Test project
│   ├── Unit/
│   └── Integration/
│
└── README.md                      # This plan + future architecture docs
```

> ⚠️ No folders/files should be created unless explicitly confirmed.

---

## ⚠️ Non-Trivial Design Decisions

1. **Recommendation Logic**:
   - Keep it manual/static initially
   - Design it with extensibility in mind (e.g., interface/strategy pattern for future AI use)

2. **Image Hosting**:
   - Store book images in `wwwroot/assets`
   - Avoid dynamic uploads for now

3. **Data Source**:
   - Use static JSON or in-memory list to define books
   - Avoid database until needed

4. **Visual Consistency**:
   - Ensure card styles, fonts, and layout are scalable and easy to modify

---

## 📚 Context Preservation Tips

- Use `README.md` to document:
  - Design decisions
  - Component responsibilities
  - Known limitations and future ideas

- Use code comments and summaries for classes/methods
- Use clean dependency injection to make components testable
- Consider using a `/Docs/` folder for diagrams or workflows (optional)

---

## ✅ Next Steps

When you're ready, **start a new thread** in Cursor for the first implementation phase:
> 🧬 **Phase 2 – Tooling & Setup**

Paste the relevant section of this plan to re-ground context in the new thread.

---

