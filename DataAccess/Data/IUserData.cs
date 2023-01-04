using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IUserData
    {
        Task AddUser(User user);
        Task DeleteUser(User user);
        Task<User> GetUser(int id);
        Task<IEnumerable<User>> GetUsers();
        Task UpdateUser(User user);
    }
}