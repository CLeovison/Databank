using DatabankApi.Database;
using Dapper;
using DatabankApi.Contracts.Data;
namespace DatabankApi.Repositories;

public class UserRepositories : IUserRepositories
{
    private readonly IDbConnectionFactory _connectionFactory;
    public UserRepositories(IDbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task<bool> CreateUserAsync(UserDto user)
    {
        using var connection = await _connectionFactory.CreateConnectionAsync();

        var result = await connection.ExecuteAsync(@"INSERT INTO Customers (Id, Username, FullName, Email, DateOfBirth) 
            VALUES (@Id, @Username, @FullName, @Email, @DateOfBirth)", user);

        return result > 0;
    }


}