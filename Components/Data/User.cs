using Microsoft.EntityFrameworkCore;
namespace ServerApp.Data
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
    }
}