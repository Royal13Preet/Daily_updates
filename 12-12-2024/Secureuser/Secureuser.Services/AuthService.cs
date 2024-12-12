using AutoMapper;
using Microsoft.IdentityModel.Tokens;
using Secureuser.DataAccess.Repositories;
using Secureuser.Models.DBModels;
using Secureuser.Models.ViewModel;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Secureuser.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private const string SecretKey = "YourLongerSecureSecretKeyHere12345";
        private readonly IMapper _mapper;

        public AuthService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public string Login(Loginuserdto loginUser)
        {
            var user = _userRepository.GetUserByUsernameAndPassword(loginUser.Username, loginUser.Password);
            if (user == null)
            {
                return "Invalid username or password.";
            }

            var token = GenerateJwtToken(new UserCreatedto
            {
                Username = user.Username,
                Role = user.Role
            });

            return token;
        }

        public string Register(UserCreatedto newUser)
        {
            var existingUser = _userRepository.GetUserByUsername(newUser.Username);
            if (existingUser != null)
            {
                return "Username already exists.";
            }

            var user = new User
            {
                Username = newUser.Username,
                Password = newUser.Password,
                Role = newUser.Role
            };
            

            _userRepository.AddUser(user);
            _userRepository.Save();

            return "User created successfully.";
        }

        public string DeleteUser(string usernameToDelete)
        {
            var user = _userRepository.GetUserByUsername(usernameToDelete);
            if (user == null)
            {
                return "User not found.";
            }

            _userRepository.RemoveUser(user);
            _userRepository.Save();

            return "User deleted successfully.";
        }

        private string GenerateJwtToken(UserCreatedto user)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, user.Role)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "YourIssuer",
                audience: "YourAudience",
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
