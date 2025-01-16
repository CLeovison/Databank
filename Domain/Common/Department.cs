namespace DatabankApi.Domain.Common;

public class Department
{
    public required string Value { get; init; }
    public Department(string value)
    {
        if(value.Length < 5){
            throw new ArgumentException(); 
        }
        Value = value;
    }
}
