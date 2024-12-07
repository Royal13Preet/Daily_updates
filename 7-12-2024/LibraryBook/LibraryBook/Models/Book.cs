namespace LibraryBook.Models
{
    public class Book
    {
        public int BookId { get; set; }

        public string BookTitle { get; set; }

        public string BookGenre { get; set; }

        public int AuthorID { get; set; }

        public Author Author { get; set; }
    }
}
