using System.Text.RegularExpressions;
using DatabankApi.Contracts.Request.UserRequest;

using DatabankApi.Domain;
using DatabankApi.Domain.Common;

namespace DatabankApi.Mapping;


public static class UserDomainToApiContract
{

    public static User ToApiContract(this CreateUserRequest user)
    {
        return new User
        {

            FirstName = new FirstName(user.FirstName, new Regex("^[a-z\\d](?:[a-z\\d]|-(?=[a-z\\d])){0,38}$")),
            LastName = new LastName(user.LastName, new Regex("^[a-z\\d](?:[a-z\\d]|-(?=[a-z\\d])){0,38}$")),
        };
    }

}