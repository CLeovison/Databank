using DatabankApi.Contracts.Data;
using DatabankApi.Domain;

namespace DatabankApi.Mapping;


public static class UserDtoToDomain
{
    public static UserDto ToDomain(this User user)
    {
        return new UserDto
        {
            FullName = user.FirstName.ToString() ?? string.Empty,
            Username = user.Username.ToString() ?? string.Empty,
            Department = user.Department.ToString() ?? string.Empty
        };
    }
}