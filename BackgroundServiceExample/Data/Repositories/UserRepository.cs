using BackgroundServiceExample.Data.Interfaces;
using BackgroundServiceExample.Models;

namespace BackgroundServiceExample.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public IEnumerable<User> GetUsersThatNameStartsWithParameter(string letter)
        {
            return _context.Users.Where(u => u.Name.StartsWith(letter)).ToList();
        }
    }
}
