using AutoMapper;
using LibraryBook.Models;
using LibraryBook.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookControler : ControllerBase
    {
        private BookContext _context;
        private readonly IMapper _mapper;

        public BookControler(BookContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Get()
        {


            //List<BookDto> bookDtos = new List<BookDto>();
            var books = _context.book.Include(x => x.Author).ToList();
            var bookDtos = _mapper.Map<List<BookDto>>(books);
            return Ok(bookDtos);

        }

        [HttpPost]

        public IActionResult Post([FromBody] BookDto bookdto)
        {
            var book = _mapper.Map<Book>(bookdto);
            _context.book.Add(book);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPut]

        public IActionResult Put(int id, [FromBody] BookDto bookdto)
        {
            var existingbook = _context.book.Where(b => b.BookId == id).FirstOrDefault();
            _mapper.Map(bookdto, existingbook);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete]

        public IActionResult Delete(int id)
        {
            var book = _context.book.Find(id);
            _context.book.Remove(book);
            _context.SaveChanges();
            return Ok();
        }

        [HttpGet("{id}")]

        public IActionResult Get(int id)
        {
            var book = _context.book.Include(x => x.Author).FirstOrDefault(b => b.BookId == id);
            //var book = _context.book.Find(id);
            var bookdto = _mapper.Map<BookDto>(book);
            return Ok(bookdto);
        }
           
            
    }









    
}
