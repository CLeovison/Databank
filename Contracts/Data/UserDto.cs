

namespace DatabankApi.Contracts.Data;

public class UserDto
{

    public Guid UserId { get; init; }
    public required string FullName { get; init; }
    public required string Username { get; init; }
    public required string Department { get; init; }

    public DateTime CreateAt { get; init; }

}