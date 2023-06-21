using RedisChat.Client.Helper;
using System;
using System.Collections.Generic;

namespace RedisChat.Client.Services
{
    public class ChatService
    {
        public static bool Login(string phoneNumber, string password)
        {
            return RedisHelper.Login(phoneNumber, password);
        }

        public static bool SignUp(string phoneNumber, string password)
        {
            return RedisHelper.SignUp(phoneNumber, password);
        }

        public static bool CreateRoom(string roomId, string password)
        {
            return RedisHelper.CreateRoom(roomId, password);
        }

        public static void SendMessage(string roomId, string message)
        {
            RedisHelper.SendMessage(roomId, message);
        }

        public static List<string> GetRooms()
        {
            return RedisHelper.GetRooms();
        }

        public static List<string> GetRoomUsers(string roomId)
        {
            return RedisHelper.GetRoomUsers(roomId);
        }

        public static List<string> GetRoomMessages(string roomId)
        {
            return RedisHelper.GetRoomMessages(roomId);
        }

        public static void SendPrivateMessage(string senderPhoneNumber, string recipientPhoneNumber, string message)
        {
            RedisHelper.SendPrivateMessage(senderPhoneNumber, recipientPhoneNumber, message);
        }

        public static List<string> GetPrivateMessages(string senderPhoneNumber, string recipientPhoneNumber)
        {
            return RedisHelper.GetPrivateMessages(senderPhoneNumber, recipientPhoneNumber);
        }
    }
}
