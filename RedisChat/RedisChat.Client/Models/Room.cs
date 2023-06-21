using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisChat.Server.Models
{
    public class Room
    {
        public string RoomId { get; set; }
        public string Password { get; set; }
        // Other room properties

        public Room(string roomId, string password)
        {
            RoomId = roomId;
            Password = password;
        }
    }

}
