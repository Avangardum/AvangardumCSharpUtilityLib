namespace Avangardum.AvangardumCSharpUtilityLib.Tests;

public class FunctionalExtensionsTests
{
    [Test]
    public void Pipe_Pipe3IntoVoidMethod_FooCalledWithCorrectArgument()
    {
        int? lastFooArgument = null;
        3.Pipe(Foo);
        Assert.That(lastFooArgument, Is.EqualTo(3));

        void Foo(int arg) => lastFooArgument = arg;
    }
    
    [Test]
    public void Pipe_Pipe3IntoDouble_6()
    {
        int result = 3.Pipe(Double);
        Assert.That(result, Is.EqualTo(6));
    }

    [Test]
    public void Compose_ComposeDoubleWithIncrementThenPass3ToResultingFunction_7()
    {
        Func<int, int> doubleThenIncrement = ((Func<int, int>)Double).Compose(Increment);
        var result = doubleThenIncrement(3);
        Assert.That(result, Is.EqualTo(7));
    }

    [Test]
    public void Compose_ComposeParseWithDoubleThenPass12ToResultingFunction_24()
    {
        Func<string, int> parseThenDouble = ((Func<string, int>)int.Parse).Compose(Double);
        var result = parseThenDouble("12");
        Assert.That(result, Is.EqualTo(24));
    }

    [Test]
    public void Compose_ComposeIntParseWithDoubleWithConvertIntToStringThenPass12ToResultingFunction_24()
    {
        Func<string, string> stringDouble = ((Func<string, int>)int.Parse).Compose(Double).Compose(ConvertIntToString);
        var result = stringDouble("12");
        Assert.That(result, Is.EqualTo("24"));
    }

    private int Increment(int value) => value + 1;

    private int Double(int value) => value * 2;

    private string ConvertIntToString(int value) => value.ToString();
}