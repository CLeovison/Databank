using DatabankApi.Domain.Common;

namespace DatabankApi.Domain;


public class User
{

    public FirstName FirstName { get; init; } = default!;
    public Username Username { get; init; } = default!;

    public LastName LastName { get; init; } = default!;
    public Birthday Birthday { get; init; } = default!;
    public Email Email { get; init; } = default!;
}