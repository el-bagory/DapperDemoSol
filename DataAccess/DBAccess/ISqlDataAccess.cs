namespace DataAccess.DBAccess;

public interface ISqlDataAccess
{
    Task<IEnumerable<T>> LoadData<T, U>(string sp, U parms, string connectionId = "default");
    Task SaveDate<T>(string sp, T parms, string connectionId = "default");
}