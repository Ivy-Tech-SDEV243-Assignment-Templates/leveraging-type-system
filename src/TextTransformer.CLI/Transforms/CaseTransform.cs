using System.Globalization;

public class CaseTransform
{
    private readonly string _option;

    public CaseTransform(string option)
    {
        _option = option;
    }

    public string Transform(string input)
    {
        return _option switch
        {
            "none" => input,
            "lower" => input.ToLower(),
            "upper" => input.ToUpper(),
            "title" => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input),
            _ => throw new ArgumentException("Invalid case option."),
        };
    }
}