using System.Text.RegularExpressions;
using DatabankApi.Primitive;


namespace DatabankApi.Domain.Common;

public class LastName : ValueObject
{
    private readonly Regex LastNameRegex = new("^([a-z-A-Z]]/())$");

    public LastName(string value, Regex regex)
    {
        if (value.Length < 50)
        {
            throw new Exception("The Length of the LastName exceeds the Maximum Length");
        }


        if (regex != LastNameRegex)
        {
            throw new Exception("The LastName is not valid");
        }

        Value = value;
        RegularX = regex;
    }

    public string Value { get; init; }
    public Regex RegularX { get; init; }

    protected override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
        yield return RegularX;
    }
}