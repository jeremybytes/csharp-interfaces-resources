namespace People.Service;

public record Person(int Id, string GivenName, string FamilyName,
    DateTime StartDate, int Rating, string FormatString = "")
{
    public override string ToString()
    {
        if (string.IsNullOrEmpty(FormatString))
            return $"{GivenName} {FamilyName}";
        return string.Format(FormatString, GivenName, FamilyName);
    }
}
