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

        int Double(int i) => i * 2;
    }
}