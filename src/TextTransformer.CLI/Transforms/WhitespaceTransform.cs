using System.Text;

public class WhitespaceTransform
{
    private static readonly char[] DefaultSentenceEndPunctuation = ['.', '!', '?'];

    private readonly int _spacesAfterSentenceEnd;
    private readonly IReadOnlyList<char> _sentenceEndPunctuationChars;

    public WhitespaceTransform(
        int spacesAfterSentenceEnd = 1,
        IEnumerable<char>? sentenceEndPunctuationChars = null)
    {
        _spacesAfterSentenceEnd = spacesAfterSentenceEnd;
        _sentenceEndPunctuationChars = sentenceEndPunctuationChars is null
            ? DefaultSentenceEndPunctuation
            // ToArray createse a defensive copy of the collection so that if
            // the user modifies the original it doesn't affect this object's
            // copy of the collection.
            : sentenceEndPunctuationChars.ToArray();
    }

    public string Transform(string input)
    {
        var sb = new StringBuilder(input.Length);
        int index = 0;

        while (index < input.Length)
        {
            char c = input[index];
            sb.Append(c);

            if (_sentenceEndPunctuationChars.Contains(c))
            {
                // Add the specified number of spaces after the sentence end punctuation.
                for (int i = 0; i < _spacesAfterSentenceEnd; i++)
                    sb.Append(' ');

                // Skip until the next non-space character or the end of the string.
                index++;
                while (index < input.Length && input[index] == ' ')
                    index++;
            }
            else if (c == ' ')
            {
                // Skip until the next non-space character or the end of the string.
                index++;
                while (index < input.Length && input[index] == ' ')
                    index++;
            }
            else
            {
                index++;
            }
        }

        return sb.ToString().Trim();
    }
}