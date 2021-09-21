using System;
using System.Collections.Generic;

namespace SpaDay.Models
{
    public class User
    {
        public DateTime DateJoined { get; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User()
        {
            DateJoined = DateTime.Now;
        }

        public User(string userName, string email, string password): this ()
        {
            UserName = userName;
            Email = email;
            Password = password;
        }

    }
}
