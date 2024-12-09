using APIwithEntityLibrary.Models;
using APIwithEntityLibrary.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIwithEntityLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly BookContext _context; //private variable

        private readonly IMapper _mapper;
        public UserController(BookContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        //Get
        [HttpGet]

        public IActionResult Get()
        {
            //local variable must start with the small letter
            var users = _context.Users.ToList();
            if(users == null)
            {
                return NotFound();
            }
            var userDtos = _mapper.Map<List<userDto>>(users);


            return Ok(userDtos);
        }

        [HttpPost]

        public IActionResult put([FromBody] userDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            _context.Users.Add(user);
            _context.SaveChanges();
            return Ok();
        }

        //get
        [HttpGet("GetUserByUserNmae/{userName}")]

        public IActionResult GetUserByUserNmae(string userName)
        {
            var user = _context.Users.FromSql($"SELECT * FROM users where userName =  {userName}").FirstOrDefault();
            if (user == null)
            {
                return NotFound();
            }
            var userDto = _mapper.Map<userDto>(user);
            return Ok(userDto);

        }
    }
}
