using DatabankApi.Primitive;

namespace DatabankApi.Domain.Common;

public class Password : ValueObject
{
    public Password(string value)
    {

        if(value.Length < 6){
            throw new ArgumentException();
        }
        Value = value;
    }

    public required string Value { get; init; }

    protected override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
}