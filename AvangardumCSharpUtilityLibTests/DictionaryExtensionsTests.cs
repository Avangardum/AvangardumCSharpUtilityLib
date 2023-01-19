namespace Avangardum.AvangardumCSharpUtilityLib.Tests;

public class DictionaryExtensionsTests
{
    [Test]
    public void GetKey_InitWith1One2Two3ThreeThenPassTwoToGetKey_2()
    {
        var dictionary = new Dictionary<int, string> { { 1, "one" }, { 2, "two" }, { 3, "three" } };
        var result = dictionary.GetKey("two");
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void GetKey_InitWith1One2Two3ThreeThenPassFourToGetKey_ThrowInvalidOperationException()
    {
        var dictionary = new Dictionary<int, string> { { 1, "one" }, { 2, "two" }, { 3, "three" } };
        Assert.Throws<InvalidOperationException>(() => dictionary.GetKey("four"));
    }

    [Test]
    public void GetKey_InitWith1One2Two3Three4TwoThenPassTwoToGetKey_ThrowInvalidOperationException()
    {
        var dictionary = new Dictionary<int, string> { { 1, "one" }, { 2, "two" }, { 3, "three" }, {4, "two"} };
        Assert.Throws<InvalidOperationException>(() => dictionary.GetKey("two"));
    }
}