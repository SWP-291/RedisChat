using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisChat.Server.Models
{
    public class User
    {
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        // Other user properties

        public User(string phoneNumber, string password)
        {
            PhoneNumber = phoneNumber;
            Password = password;
        }
    }
}
