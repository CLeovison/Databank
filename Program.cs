using Dapper;
using DatabankApi.Contracts.Request.UserRequest;
using DatabankApi.Database;
using Npgsql;


var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

builder.Services.AddSingleton<IDbConnectionFactory>(_ =>
    new PostgresConnectionFactory(config.GetValue<string>("ConnectionStrings:DefaultConnection")));

var app = builder.Build();





app.MapGet("/users", async (IDbConnectionFactory connectionFactory) =>
{
    using var connection = await connectionFactory.CreateConnectionAsync();
    const string sql = " SELECT * FROM users";

    var users = await connection.QueryAsync<CreateUserRequest>(sql);
    return Results.Ok(users);
});

app.MapPost("/users/register", async (IDbConnectionFactory connectionFactory, CreateUserRequest user) =>
{
    using var connection = await connectionFactory.CreateConnectionAsync();
    const string sql = "INSERT INTO users (username, password, firstname, lastname, department, email) VALUES (@username, @password, @firstname, @lastname, @department, @email)";
    await connection.ExecuteAsync(sql, user);

    return Results.Ok();
});


app.Run();
