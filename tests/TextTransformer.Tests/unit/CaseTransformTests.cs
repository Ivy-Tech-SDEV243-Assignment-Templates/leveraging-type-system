public class CaseTransformTests
{
    [Fact]
    public void none_transform_changes_nothing()
    {
        var transform = new CaseTransform("none");
        var result = transform.Transform("MiXeD Case w/ PunctuatioN!");
        Assert.Equal("MiXeD Case w/ PunctuatioN!", result);
    }

    [Fact]
    public void lowercase_transform_lowercases_text_at_any_position_and_leaves_punctuation_unchanged()
    {
        var transform = new CaseTransform("lower");
        var result = transform.Transform("MiXeD Case w/ PunctuatioN!");
        Assert.Equal("mixed case w/ punctuation!", result);
    }

    [Fact]
    public void uppercase_transform_uppercases_text_at_any_position_and_leaves_punctuation_unchanged()
    {
        var transform = new CaseTransform("upper");
        var result = transform.Transform("MiXeD Case w/ PunctuatioN!");
        Assert.Equal("MIXED CASE W/ PUNCTUATION!", result);
    }

    [Fact]
    public void titlecase_transform_converts_text_to_title_case_and_leaves_punctuation_unchanged()
    {
        var transform = new CaseTransform("title");
        var result = transform.Transform("MiXeD Case w/ PunctuatioN!");
        Assert.Equal("Mixed Case W/ Punctuation!", result);
    }
}
