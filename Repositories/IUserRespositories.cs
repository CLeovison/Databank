using DatabankApi.Contracts.Data;

namespace DatabankApi.Repositories;


public interface IUserRepositories
{
    Task<bool> CreateUserAsync(UserDto user);
    Task<UserDto?> GetUserAsync(Guid id);
    Task<IEnumerable<UserDto>> GetAllUserAsync();
    Task<bool> UpdateUserAsync(UserDto user);
    Task<bool> DeleteUserAsync(Guid id);
    Task<bool> ResetUserPasswordAsync(Guid id);
    Task<bool> ForgotUserPassswordAsync(Guid id);

}