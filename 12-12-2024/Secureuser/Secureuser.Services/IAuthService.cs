using Secureuser.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secureuser.Services
{
    public interface IAuthService
    {
        /// <summary>
        /// for user and admin login
        /// </summary>
        /// <param name="loginUser"></param>
        /// <returns></returns>
        string Login(Loginuserdto loginUser);
        /// <summary>
        /// for creating new user
        /// </summary>
        /// <param name="newUser"></param>
        /// <returns></returns>
        string Register(UserCreatedto newUser);
        /// <summary>
        /// deleting the user
        /// </summary>
        /// <param name="usernameToDelete"></param>
        /// <returns></returns>
        string DeleteUser(string usernameToDelete);

    }
}
