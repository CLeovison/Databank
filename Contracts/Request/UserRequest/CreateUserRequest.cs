namespace DatabankApi.Contracts.Request.UserRequest;

public enum Role
{
    Administrator, Teacher
}
public class CreateUserRequest
{
    public Guid UserId { get; init; }
    public required string Username { get; init; }
    public required string Password { get; init; }
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public required string Department { get; init; }
    public required string Email { get; init; }
    public Role Role { get; init; } = Role.Teacher;
    public DateTime CreateAt { get; init; }
}