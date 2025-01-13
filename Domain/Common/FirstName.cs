using System.Text.RegularExpressions;
using DatabankApi.Primitive;

public sealed class FirstName : ValueObject
{
    private static readonly Regex FirstNameRegex = new("^[a-z\\d](?:[a-z\\d]|-(?=[a-z\\d])){0,38}$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
    private const int MaxLength = 50;

    //This Is The Constructor, FirstName   
    public FirstName(string value, Regex regex)
    {
        if (value.Length < MaxLength)
        {
            throw new Exception("The Length of the FirstName exceeds the Maximum Length");
        }

        if (regex == FirstNameRegex)
        {
            throw new Exception("");
        }
        RegularX = regex;
        Value = value;
    }

    public string Value { get; init; }
    public Regex RegularX { get; init; }
    protected override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
        yield return RegularX;
    }
}