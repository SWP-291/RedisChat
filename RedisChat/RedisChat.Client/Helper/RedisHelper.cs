using StackExchange.Redis;
using System.Collections.Generic;

namespace RedisChat.Client.Helper
{
    public static class RedisHelper
    {
        private static ConnectionMultiplexer _redis;
        public static IDatabase RedisDB { get; private set; }

        public static void Connect()
        {
            _redis = ConnectionMultiplexer.Connect("127.0.0.1:6379");
            RedisDB = _redis.GetDatabase();
        }

        /// <summary>
        /// Login
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool Login(string phoneNumber, string password)
        {
            string userKey = $"user:{phoneNumber}";
            string savedPassword = RedisDB.StringGet(userKey);

            return password == savedPassword;
        }

        /// <summary>
        /// Sign Up
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool SignUp(string phoneNumber, string password)
        {
            string userKey = $"user:{phoneNumber}";
            bool isPhoneNumberAvailable = !RedisDB.KeyExists(userKey);

            if (isPhoneNumberAvailable)
            {
                RedisDB.StringSet(userKey, password);
            }

            return isPhoneNumberAvailable;
        }

        /// <summary>
        /// Create a new room.
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool CreateRoom(string roomId, string password)
        {
            string roomKey = $"room:{roomId}";
            bool isRoomIdAvailable = !RedisDB.KeyExists(roomKey);

            if (isRoomIdAvailable)
            {
                RedisDB.StringSet(roomKey, password);
            }

            return isRoomIdAvailable;
        }

        /// <summary>
        /// Send message in room
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="message"></param>
        public static void SendMessage(string roomId, string message)
        {
            string messageKey = $"messages:{roomId}";
            RedisDB.ListRightPush(messageKey, message);
        }

        /// <summary>
        /// Get Rooms
        /// </summary>
        /// <returns></returns>
        public static List<string> GetRooms()
        {
            List<string> rooms = new List<string>();
            var server = _redis.GetServer("localhost");

            foreach (var key in server.Keys(pattern: "room:*"))
            {
                string roomId = key.ToString().Substring(5);
                rooms.Add(roomId);
            }

            return rooms;
        }

        /// <summary>
        /// Get list User in a room.
        /// </summary>
        /// <param name="roomId"></param>
        /// <returns></returns>
        public static List<string> GetRoomUsers(string roomId)
        {
            string roomUsersKey = $"room:{roomId}:users";
            List<string> users = new List<string>();

            if (RedisDB.KeyExists(roomUsersKey))
            {
                var userSet = RedisDB.SetMembers(roomUsersKey);
                foreach (var user in userSet)
                {
                    users.Add(user);
                }
            }

            return users;
        }

        /// <summary>
        /// Get list msg of a room
        /// </summary>
        /// <param name="roomId"></param>
        /// <returns></returns>
        public static List<string> GetRoomMessages(string roomId)
        {
            string messageKey = $"messages:{roomId}";
            List<string> messages = new List<string>();

            if (RedisDB.KeyExists(messageKey))
            {
                var messageList = RedisDB.ListRange(messageKey);
                messages.AddRange(messageList.ToStringArray());
            }

            return messages;
        }


        /// <summary>
        /// Send private msg
        /// </summary>
        /// <param name="senderPhoneNumber"></param>
        /// <param name="recipientPhoneNumber"></param>
        /// <param name="message"></param>
        public static void SendPrivateMessage(string senderPhoneNumber, string recipientPhoneNumber, string message)
        {
            string chatKey = GetChatKey(senderPhoneNumber, recipientPhoneNumber);

            RedisDB.ListRightPush(chatKey, message);
        }

        /// <summary>
        /// List Private massage
        /// </summary>
        /// <param name="senderPhoneNumber"></param>
        /// <param name="recipientPhoneNumber"></param>
        /// <returns></returns>
        public static List<string> GetPrivateMessages(string senderPhoneNumber, string recipientPhoneNumber)
        {
            string chatKey = GetChatKey(senderPhoneNumber, recipientPhoneNumber);
            List<string> messages = new List<string>();

            if (RedisDB.KeyExists(chatKey))
            {
                var messageList = RedisDB.ListRange(chatKey);
                messages.AddRange(messageList.ToStringArray());
            }

            return messages;
        }

        /// <summary>
        ///  1-1 chatting
        /// </summary>
        /// <param name="phoneNumber1"></param>
        /// <param name="phoneNumber2"></param>
        /// <returns></returns>
        private static string GetChatKey(string phoneNumber1, string phoneNumber2)
        {
            // Đảo ngược thứ tự hai số điện thoại để tạo khóa chat duy nhất
            string sortedPhoneNumbers = string.Concat(phoneNumber1, ":", phoneNumber2);
            string chatKey = $"chat:{sortedPhoneNumbers}";

            return chatKey;
        }

    }
}
