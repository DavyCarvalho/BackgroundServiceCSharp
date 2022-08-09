using BackgroundServiceExample.Models;

namespace BackgroundServiceExample.Data.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsersThatNameStartsWithParameter(string letter);

        IEnumerable<User> GetAllUsers();
    }
}
