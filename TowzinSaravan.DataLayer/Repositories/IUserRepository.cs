using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowzinSaravan.DataLayer.Repositories
{
    public interface IUserRepository
    {
        List<Users> GetAllUsers();
        IEnumerable<Users> GetUsersByFilter(string parameter);
        Users GetUserById(int userId);
        Users GetUserByUsername(string username);
        int GetUserId(string username);
        bool CheckUserForLogin(string username, string password);
        bool InsertUser(Users user);
        bool UpdateUser(Users user);
        bool DeleteUser(Users user);
        bool DeleteUser(int userId);
    }
}
