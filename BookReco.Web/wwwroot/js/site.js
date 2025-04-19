// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Book filtering functionality
document.addEventListener('DOMContentLoaded', function() {
    const searchForm = document.getElementById('bookSearchForm');
    const searchInput = document.getElementById('bookSearchInput');
    const booksGrid = document.querySelector('.books-grid');
    
    if (searchForm && searchInput && booksGrid) {
        // Prevent form submission
        searchForm.addEventListener('submit', function(e) {
            e.preventDefault();
        });

        // Add input event listener for real-time filtering
        searchInput.addEventListener('input', function() {
            const searchTerm = this.value.toLowerCase().trim();
            const bookItems = booksGrid.querySelectorAll('.book-item');

            bookItems.forEach(function(bookItem) {
                const title = bookItem.querySelector('.book-title').textContent.toLowerCase();
                const author = bookItem.querySelector('.book-author').textContent.toLowerCase();
                
                if (title.includes(searchTerm) || author.includes(searchTerm)) {
                    bookItem.style.display = '';
                } else {
                    bookItem.style.display = 'none';
                }
            });
        });
    }
});
