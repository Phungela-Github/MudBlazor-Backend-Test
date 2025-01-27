using System.Linq;
using System.Threading.Tasks;
using ServerApp.Data;
using Microsoft.EntityFrameworkCore;

namespace ServerApp.Services
{
    public class UserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> RegisterUser(string username, string password)
        {
            if (_context.Users.Any(u => u.Username == username))
                return false;

            var user = new NewUser
            {
                Username = username,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(password)
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<NewUser> AuthenticateUser(string username, string password)
        {
            var user = await _context.Users.SingleOrDefaultAsync(u => u.Username == username);

            if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
                return null;

            return user;
        }
    }
}