﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public User(string userName, string email, string password)
        {
            Name = userName;
            Email = email;
            Password = password;
        }
    }

}
