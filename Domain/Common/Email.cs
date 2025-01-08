using System.Text.RegularExpressions;

namespace DatabankApi.Domain.Common;

public class Email
{
    private readonly Regex EmailRegex = new(
        "^[\\w!#$%&’*+/=?`{|}~^-]+(?:\\.[\\w!#$%&’*+/=?`{|}~^-]+)*@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$",
        RegexOptions.Compiled | RegexOptions.IgnoreCase);

    private int MinLength = 6;

    public Email(Regex regex, string value)
    {
        if (value.Length < MinLength)
        {
            throw new Exception("Email was 6 to 30 characters long");
        }

        if (EmailRegex != regex)
        {
            throw new Exception("You cannot include any special character");
        }

        EmailRegularX = regex;
        Value = value;
    }

    public string Value { get; init; }
    public Regex EmailRegularX { get; init; }
}