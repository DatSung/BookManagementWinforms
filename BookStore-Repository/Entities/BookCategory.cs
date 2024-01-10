using System;
using System.Collections.Generic;

namespace BookStore_Repository.Entities
{
    public partial class BookCategory
    {
        public BookCategory()
        {
            Books = new HashSet<Book>();
        }

        public int BookCategoryId { get; set; }
        public string BookGenreType { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual ICollection<Book> Books { get; set; }
    }
}
