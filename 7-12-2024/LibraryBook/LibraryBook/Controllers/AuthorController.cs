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
    public class AuthorController : ControllerBase
    {
        private BookContext _authorContext;
        private readonly IMapper _mapper;

        public AuthorController(BookContext bookContext, IMapper mapper)
        {
            _authorContext = bookContext;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult Get()
        {
            var authors = _authorContext.author.ToList();
            var authordto = _mapper.Map<List<AuthorDto>>(authors);
            return Ok(authordto);

        }

        [HttpPost]
        public IActionResult Post([FromBody] AuthorDto author)
        {

            var authors = _mapper.Map<Author>(author);
            _authorContext.author.Add(authors);
            _authorContext.SaveChanges();
            return Ok(author);

        }

        [HttpPut]

        public IActionResult Put(int id, [FromBody] AuthorDto authordto)
        {
            var existingbook = _authorContext.author.Where(x => x.AuthorID == id).FirstOrDefault();
            _mapper.Map(authordto,existingbook);
            _authorContext.SaveChanges();
            return Ok();
        }

        [HttpDelete]

        public IActionResult Dele(int id)
        {
            var authors = _authorContext.author.Find(id);
            _authorContext.author.Remove(authors);
            _authorContext.SaveChanges();

            return Ok();
        }

        [HttpGet("{id}")]

        public IActionResult gett(int id) {

            var authors = _authorContext.author.Find(id);
            var auth = _mapper.Map<AuthorDto>(authors);
            return Ok(auth);
        
        }
    }
}
