using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowzinSaravan.DataLayer.Repositories;

namespace TowzinSaravan.DataLayer.Services
{
    public class UserRepository : IUserRepository
    {
        private TowzinSaravan_DBEntities db;

        public UserRepository(TowzinSaravan_DBEntities context)
        {
            db = context;
        }

        public List<Users> GetAllUsers()
        {
            return db.Users.ToList();
        }

        public Users GetUserById(int userId)
        {
            return db.Users.Find(userId);
        }

        public bool InsertUser(Users user)
        {
            try
            {
                db.Users.Add(user);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateUser(Users user)
        {
            try
            {
                db.Entry(user).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteUser(Users user)
        {
            try
            {
                db.Entry(user).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteUser(int userId)
        {
            try
            {
                var user = GetUserById(userId);
                DeleteUser(user);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<Users> GetUsersByFilter(string parameter)
        {
            return db.Users.Where(u =>
                        u.Firstname.Contains(parameter) ||
                        u.Lastname.Contains(parameter) ||
                        u.Username.Contains(parameter)).ToList();

        }

        public Users GetUserByUsername(string username)
        {
            return db.Users.Where(u => u.Username == username).SingleOrDefault();
        }

        public bool CheckUserForLogin(string username, string password)
        {
            return db.Users.Where(u => u.Username == username && u.Password == password).Any();

        }

        public int GetUserId(string username)
        {
            return db.Users.Where(u => u.Username == username).Select(u => u.Id).FirstOrDefault();
        }
    }
}
