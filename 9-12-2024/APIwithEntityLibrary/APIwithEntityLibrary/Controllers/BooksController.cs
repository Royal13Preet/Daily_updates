using APIwithEntityLibrary.Models;
using APIwithEntityLibrary.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;

namespace APIwithEntityLibrary.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        
        public BookContext _context;
        private readonly IMapper _mapper;
        

        public BooksController(BookContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        //Get: api/Books

        [HttpGet]

        public IActionResult Get()
        {
            //using(var context = new BookContext())
            //{
            //    var books = context.Books.ToList();
            //   
            //}
            List<Bookdto> bookDtos = new List<Bookdto>();
            var books = _context.Books.Include(x => x.author).ToList();
            _mapper.Map(books, bookDtos);
           
            return Ok(bookDtos);
        }
        //Post = api/bbok

        [HttpPost] 

        public IActionResult Post([FromBody] Bookdto bookdto)
        {
            var book = _mapper.Map<Book>(bookdto);
            _context.Books.Add(book);
            _context.SaveChanges();
            return Ok();
        }
        //PUT ; api/book

        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, [FromBody] Bookdto bookDto)
        {
            var existingBook =  _context.Books.Where(x=>x.BookId==id).Include(y=>y.author).First();
            _mapper.Map(bookDto, existingBook);
            _context.SaveChanges();
            return NoContent();
        }

        //Get
        
        //Delete
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var book = _context.Books.Find(id);

            _context.Books.Remove(book);
            _context.SaveChanges();

            return NoContent();
        }



        //Get->single book details
        [HttpGet("{id}")]
        public IActionResult GetSingleBook(int id)
        {
            var book = _context.Books.Find(id);
            if (book == null)
            {
                return NotFound();
            }
            
            var bookDto = _mapper.Map<Bookdto>(book);
            return Ok(bookDto);
        }
    }
}
