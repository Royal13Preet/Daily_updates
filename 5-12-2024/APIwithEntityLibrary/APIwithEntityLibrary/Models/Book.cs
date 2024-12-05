namespace APIwithEntityLibrary.Models
{
    public class Book
    {
        public int BookId { get; set; }

        public string Title { get; set; }

        
        public int AuthorId { get; set; }
        public virtual Author author { get; set; }

        public virtual ICollection<BookCategory> BookCategories { get; set; }
    }
}
