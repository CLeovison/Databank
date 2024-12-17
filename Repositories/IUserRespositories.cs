using DatabankApi.Contracts.Data;

namespace DatabankApi.Repositories;


public interface IUserRepositories
{
    Task<bool> CreateUserAsync(UserDto user);
    Task<UserDto?> GetUserAsync(Guid id);


}