public class EmojiTransformTests
{
    [Fact]
    public void emoji_transform_returns_input_unchanged_when_emoji_map_is_empty()
    {
        var transform = new EmojiTransform(new Dictionary<string, string>());
        var result = transform.Transform("The quest to catch the great dragon.");
        Assert.Equal("The quest to catch the great dragon.", result);
    }

    [Fact]
    public void emoji_transform_replaces_keywords_with_emojis_when_input_case_matches_provided_keyword()
    {
        var transform = new EmojiTransform(new Dictionary<string, string> { { "dragon", "🐉" } });
        var result = transform.Transform("The quest to catch the great dragon.");
        Assert.Equal("The quest to catch the great 🐉.", result);
    }
    
    [Fact]
    public void emoji_transform_replaces_keywords_with_emojis_when_input_case_does_not_match_provided_keyword()
    {
        var transform = new EmojiTransform(new Dictionary<string, string> { { "dragon", "🐉" } });
        var result = transform.Transform("The quest to catch the great DrAGon.");
        Assert.Equal("The quest to catch the great 🐉.", result);
    }
}