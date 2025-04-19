# Book Recommendation Website - Architecture Document

## User Journey & UI Pages

### User Journey
1. User lands on homepage
2. Sees featured book recommendation
3. Can view book details
4. Simple, focused experience

### Main UI Pages
1. **Homepage** (`/`)
   - Featured book recommendation
   - Clean, modern layout
   - Book card component
   - Optional "About" section

2. **Book Detail Page** (`/book/{id}`) - Optional
   - Expanded book view
   - Detailed information
   - Larger image display

## Content Strategy

### Static Content
- Book images (`/wwwroot/assets`)
- Site structure and layout
- CSS styles and UI components
- Initial book data (JSON/hardcoded)

### Dynamic Content
- Book recommendations (static initially, dynamic later)
- View counts/engagement metrics (future)
- User preferences (future)

## Technical Architecture

### Rendering Strategy
- ASP.NET MVC views
- Razor templating
- Partial views for components
- Layout page for structure

### Optional Backend Features
1. Admin Interface
   - Book management
   - Recommendation updates

2. Future Features
   - AI-generated summaries
   - User feedback system
   - Analytics tracking

## Component Structure

### Core Components
1. Book Card Component
   - Image
   - Title
   - Author
   - Summary
   - Recommendation reason

2. Layout Components
   - Header
   - Footer
   - Navigation (minimal)

## Data Flow
1. Initial Load
   - Static book data loaded
   - Recommendation selected
   - View rendered

2. Future Dynamic Flow
   - User interaction tracked
   - Recommendations updated
   - Analytics collected 