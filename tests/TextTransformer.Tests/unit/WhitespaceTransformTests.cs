public class WhitespaceTransformTests
{
    [Fact]
    public void start_and_end_whitespace_is_removed()
    {
        var transform = new WhitespaceTransform();
        string input = "  this is the sentence ";
        string expected = "this is the sentence";
        string result = transform.Transform(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void words_within_sentence_have_single_space_between_them_when_input_contains_varying_number_of_spaces()
    {
        var transform = new WhitespaceTransform();
        string input = "this is  the   sentence";
        string expected = "this is the sentence";
        string result = transform.Transform(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void words_within_sentence_have_single_space_between_them()
    {
        var transform = new WhitespaceTransform();
        string input = "a,  b.   c!  d?  e;  f:  g-  h_  i(  j)  k\"  l'  m@  n#";
        string expected = "a, b. c! d? e; f: g- h_ i( j) k\" l' m@ n#";
        string result = transform.Transform(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void specified_number_of_spaces_are_added_after_sentence_end_punctuation()
    {
        var transform = new WhitespaceTransform( spacesAfterSentenceEnd: 2);
        string input = "a.b! c?   d;e:f";
        string expected = "a.  b!  c?  d;e:f";
        string result = transform.Transform(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void custom_sentence_end_punctuation_is_respected_when_provided()
    {
        var transform = new WhitespaceTransform( sentenceEndPunctuationChars: ['#', '@']);
        string input = "ab#c@d";
        string expected = "ab# c@ d";
        string result = transform.Transform(input);
        Assert.Equal(expected, result);
    }
}