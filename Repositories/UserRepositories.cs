using DatabankApi.Database;
using Dapper;
using DatabankApi.Contracts.Data;
namespace DatabankApi.Repositories;

public class UserRepositories : IUserRepositories
{
    private readonly IDbConnectionFactory _connectionString;

    public UserRepositories(IDbConnectionFactory connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task<bool> CreateUserAsync(UserDto user){
        var connection = await _connectionString.CreateConnectionAsync();
        var result = await connection.ExecuteAsync(@"INSERT INTO users (userid,username,password,firstname,lastname,department,email,createdat)");

        return result > 0;
    }

    public async Task<UserDto?> GetUserAsync(Guid id){
        var connection = await _connectionString.CreateConnectionAsync();
        var result = await connection.QuerySingleOrDefaultAsync<UserDto>( "SELECT * FROM Customers WHERE Id = @Id LIMIT 1", new { Id = id.ToString() });
        return result;
    }
}