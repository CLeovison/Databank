using System.Text.RegularExpressions;
using DatabankApi.Primitive;

public class Birthday : ValueObject
{

    private readonly Regex BirthdayRegex = new(
        "^(0[1-9]|1[0-2])/(0[1-9]|1[0-9]|2[0-9]|3[0-1])/(19[0-9][0-9]|20[0-9][0-9]|2100)$",
        RegexOptions.Compiled | RegexOptions.IgnoreCase);
        
    public Birthday(DateOnly bday, Regex regex)
    {
        if (bday > DateOnly.FromDateTime(DateTime.Now))
        {
            throw new Exception("You must not be born in the future");
        }

        if (BirthdayRegex != regex)
        {
            throw new ArgumentException("You Must Not Born In Future");
        }
        BirthYear = bday;
        BirthdayRegularX = regex;
    }

    public DateOnly BirthYear { get; init; }
    public Regex BirthdayRegularX { get; init; }

    protected override IEnumerable<object> GetAtomicValues()
    {
        yield return BirthYear;
    }
}