using System.Text.RegularExpressions;

namespace DatabankApi.Domain.Common;

public class Email
{
    private readonly Regex EmailRegex = new("^[]$");


    public Email()
    {

    }

    public string MinLength { get; init; }
    public Regex EmailRegularX { get; init; }
}