using System.Data;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace DataAccess.DBAccess;

public class SqlDataAccess : ISqlDataAccess
{
    private readonly IConfiguration _config;
    public SqlDataAccess(IConfiguration config)
    {
        _config = config;
    }

    public async Task<IEnumerable<T>> LoadData<T, U>(
        string sp,
        U parms,
        string connectionId = "default")
    {
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

        return await connection.QueryAsync<T>(sp, parms, commandType: CommandType.StoredProcedure);
    }


    public async Task SaveDate<T>(
        string sp,
        T parms,
        string connectionId = "default"
        )
    {
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

        await connection.ExecuteAsync(sp, parms, commandType: CommandType.StoredProcedure);
    }

}
