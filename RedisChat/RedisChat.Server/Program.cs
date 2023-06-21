using RedisChat.Server;
using RedisChat.Server.Models;

class Program
{
    static void Main(string[] args)
    {
        // Tạo RedisService với connection string của Redis server
        RedisService redisService = new RedisService("127.0.0.1:6379");

        // Thực hiện xử lý logic và gọi các phương thức từ RedisService
        // Ví dụ: Đăng nhập
        string phoneNumber = "your_phone_number";
        string password = "your_password";

        User user = redisService.GetUser(phoneNumber);

        if (user != null && user.Password == password)
        {
            Console.WriteLine("Đăng nhập thành công!");
            // Thực hiện các xử lý logic khác sau khi đăng nhập thành công
        }
        else
        {
            Console.WriteLine("Số điện thoại hoặc mật khẩu không đúng!");
        }

        // Tiếp tục thực hiện các xử lý logic khác theo yêu cầu của ứng dụng chat

        // Dừng chương trình để người dùng có thể đọc thông báo
        Console.ReadLine();
    }
}
