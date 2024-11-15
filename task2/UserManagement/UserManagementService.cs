using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    public class UserManagementService : IUserManagementService
    {
        private List<User> users = new List<User>();
        public User Register(string name, string email, string password)
        {
            var user = new User(name, email, password);
            users.Add(user);
            return user;
        }
        public User Login(string email, string password)
        {
            return users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }
    }
}
