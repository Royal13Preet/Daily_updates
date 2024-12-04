namespace APIwithEntityLibrary.Models
{
    public class Book
    {
        public int BookId { get; set; }

        public string Title { get; set; }

        public int AuthorId { get; set; }
        public Author author { get; set; }

        public ICollection<BookCategory> BookCategories { get; set; }
    }
}
