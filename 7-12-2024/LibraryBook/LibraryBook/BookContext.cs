using LibraryBook.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryBook
{
    public class BookContext : DbContext
    {
        public DbSet<Book> book {  get; set; }

        public DbSet<Author> author { get; set; }


        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

        }

        public BookContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Book>()
                .HasOne(b => b.Author)
                .WithMany(c => c.books)
                .HasForeignKey(b => b.AuthorID);

            modelbuilder.Entity<Author>().HasData(
                new Author { AuthorID = 1, AuthorName = "Ravinder" },
                new Author { AuthorID = 2, AuthorName = "Mark Douglass"},
                new Author { AuthorID = 3, AuthorName = "Kuvempu"}
            );

            modelbuilder.Entity<Book>().HasData(
                new Book { BookId = 10, BookTitle = "Can Love Happen Twice", BookGenre = "Romantic",AuthorID=1},
                new Book { BookId = 11, BookTitle = "The house of Kanooru", BookGenre = "LifeStyle", AuthorID = 3},
                new Book { BookId = 12, BookTitle = "Like it happend yesterday", BookGenre = "Childhood",AuthorID = 1}
            );

        }


    }
}
