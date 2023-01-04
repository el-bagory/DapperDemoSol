using DataAccess.DBAccess;
using DataAccess.Models;

namespace DataAccess.Data;

public class UserData : IUserData
{
    private readonly ISqlDataAccess _db;
    public UserData(ISqlDataAccess db)
    {
        _db = db;
    }
    public Task<IEnumerable<User>> GetUsers() =>
        _db.LoadData<User, dynamic>("[dbo].[spUser_GetAll]", new { });

    public async Task<User> GetUser(int id)
    {
        var res = await _db.LoadData<User, dynamic>("[dbo].[spUser_Get]", new { });
        return res.FirstOrDefault();
    }
    public async Task AddUser(User user) =>
        await _db.SaveDate("[dbo].[spUser_Insert]", new { user.FName, user.LName });

    public async Task UpdateUser(User user) =>
        await _db.SaveDate("[dbo].[spUser_Update]", user);

    public async Task DeleteUser(User user) =>
        await _db.SaveDate("[dbo].[spUser_Delete]", new { user.Id });



}
