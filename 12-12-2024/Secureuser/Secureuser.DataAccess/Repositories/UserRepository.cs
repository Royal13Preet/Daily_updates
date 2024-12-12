using Secureuser.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secureuser.DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
      
            private readonly ProjectDbContext _context;

            public UserRepository(ProjectDbContext context)
            {
                _context = context;
            }

        public User GetUserByUsernameAndPassword(string username, string password)
        {
            try
            {
                return _context.users.FirstOrDefault(u => u.Username == username && u.Password == password);
            }
            catch (Exception ex)
            {
                throw new Exception("Error while fetching user by username and password.", ex);
            }
        }

        public User GetUserByUsername(string username)
            {
                try
                {
                    return _context.users.FirstOrDefault(u => u.Username == username);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error while fetching user by username.", ex);
                }
            }

            public void AddUser(User user)
            {
                try
                {
                    _context.users.Add(user);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error while adding user.", ex);
                }
            }

            public void RemoveUser(User user)
            {
                try
                {
                    _context.users.Remove(user);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error while removing user.", ex);
                }
            }

            public void Save()
            {
                try
                {
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error while saving changes to the database.", ex);
                }
            }
        public List<User> GetAllUsers()
        {
            try
            {
                return _context.users.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error while fetching all users.", ex);
            }
        }
    }
    }

