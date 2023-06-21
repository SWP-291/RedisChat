using RedisChat.Server.Models;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisChat.Server
{
    public class RedisService
    {
        private readonly ConnectionMultiplexer _redis;
        private readonly IDatabase _database;

        public RedisService(string connectionString)
        {
            _redis = ConnectionMultiplexer.Connect(connectionString);
            _database = _redis.GetDatabase();
        }

        public User GetUser(string phoneNumber)
        {
            string userKey = $"user:{phoneNumber}";
            string password = _database.HashGet(userKey, "password");
            // Retrieve other user properties

            if (string.IsNullOrEmpty(password))
                return null;

            return new User(phoneNumber, password);
        }

        public void CreateUser(User user)
        {
            string userKey = $"user:{user.PhoneNumber}";
            var hashEntries = new HashEntry[]
            {
            new HashEntry("password", user.Password)
                // Add other user properties as hash entries
            };
            _database.HashSet(userKey, hashEntries);
        }

        public Room GetRoom(string roomId)
        {
            string roomKey = $"room:{roomId}";
            string password = _database.HashGet(roomKey, "password");
            // Retrieve other room properties

            if (string.IsNullOrEmpty(password))
                return null;

            return new Room(roomId, password);
        }

        public void CreateRoom(Room room)
        {
            string roomKey = $"room:{room.RoomId}";
            var hashEntries = new HashEntry[]
            {
            new HashEntry("password", room.Password)
                // Add other room properties as hash entries
            };
            _database.HashSet(roomKey, hashEntries);
        }
    }
}
