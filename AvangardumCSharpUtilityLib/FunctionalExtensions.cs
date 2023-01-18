namespace Avangardum.AvangardumCSharpUtilityLib;

public static class FunctionalExtensions
{
    public static void Pipe<TIn>(this TIn value, Action<TIn> func) => func(value);
    
    public static TOut Pipe<TIn, TOut>(this TIn value, Func<TIn, TOut> func) => func(value);
}