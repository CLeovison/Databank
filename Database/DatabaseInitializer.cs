using Dapper;

namespace DatabankApi.Database;


public class DatabaseIntializer
{
    private readonly IDbConnectionFactory _connectionFactory;


    public DatabaseIntializer(IDbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task InitializeAsync()
    {
        using var connection = await _connectionFactory.CreateConnectionAsync();
        await connection.ExecuteAsync(@"CREATE TABLE IF NOT EXISTS users(
    userid uuid NOT NULL DEFAULT gen_random_uuid(),
    username text  NOT NULL,
    password text  NOT NULL,
    firstname text  NOT NULL,
    lastname text  NOT NULL,
    department text  NOT NULL,
    email text  NOT NULL,)");
    }

}