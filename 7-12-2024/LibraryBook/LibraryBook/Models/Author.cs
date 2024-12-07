using System.Text.Json.Serialization;

namespace LibraryBook.Models
{
    public class Author
    {
        public int AuthorID { get; set; }

        public string AuthorName { get; set; }
       
        public ICollection<Book> books { get; set; }
    }
}
