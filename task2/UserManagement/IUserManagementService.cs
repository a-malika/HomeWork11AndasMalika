using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    public interface IUserManagementService
    {
        User Register(string name, string email, string password);
        User Login(string email, string password);
    }
}
