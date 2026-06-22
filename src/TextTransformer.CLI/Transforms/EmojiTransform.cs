using System.Text.RegularExpressions;

public class EmojiTransform
{
    private readonly Dictionary<string, string> _emojiMap;

    public EmojiTransform(Dictionary<string, string> emojiMap)
    {
        _emojiMap = emojiMap;
    }

    public string Transform(string input)
    {
        if (_emojiMap.Count == 0)
            return input;

        // Performance with this approach is awful;
        // regex should be used instead.
        foreach (var (keyword, emoji) in _emojiMap)
            input = input.Replace(keyword, emoji, StringComparison.OrdinalIgnoreCase);
        return input;

        // We are building a regex pattern that matches any of the keywords in
        // the emoji map.  It must be ordered by length descending so that the
        // longest keywords are matched first; otherwise if we had "foo" and
        // "foobar" then "foobar" there would be matching issues.

        // var pattern = string.Join("|", _emojiMap.Keys
        //     .OrderByDescending(k => k.Length)
        //     .Select(Regex.Escape));
        // var regex = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);

        // var result = regex.Replace(input, match => 
        //     _emojiMap.First(kvp => string.Equals(kvp.Key, match.Value, StringComparison.OrdinalIgnoreCase)).Value
        // );

        // return result;
    }
}