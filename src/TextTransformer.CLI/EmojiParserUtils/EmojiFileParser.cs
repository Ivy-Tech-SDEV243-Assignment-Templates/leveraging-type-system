public static class EmojiFileParser
{
    // The emoji file should have key-value pairs, one per line, separated by an equals sign, e.g.:
    // heart = ❤️
    // sun = 🌞
    // A proper implementation would have more validation, but we'll assume that it is valid for this project.
    public static Dictionary<string, string> Parse(string emojiMapPath)
    {
        return File.ReadAllLines(emojiMapPath)
            .ToDictionary(line => line.Split('=')[0].Trim(), line => line.Split('=')[1].Trim());
    }
}