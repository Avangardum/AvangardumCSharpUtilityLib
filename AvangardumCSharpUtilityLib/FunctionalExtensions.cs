using System;

namespace Avangardum.AvangardumCSharpUtilityLib
{
    public static class FunctionalExtensions
    {
        /// <summary>
        /// Passes a value to a given function. Example:<br/>
        /// 3.Pipe(Console.WriteLine)
        /// </summary>
        public static void Pipe<TIn>(this TIn value, Action<TIn> func) => func(value);
    
        /// <summary>
        /// Passes a value to a given function and returns its result. Example:<br/>
        /// int result = "3".Pipe(int.Parse) // 3
        /// </summary>
        public static TOut Pipe<TIn, TOut>(this TIn value, Func<TIn, TOut> func) => func(value);

        /// <summary>
        /// Composes two functions into a new function that passes func1 result into func2. Example:<br/>
        /// Func&lt;string, int&gt; parseThenDouble = ((Func&lt;string, int&gt;)int.Parse).Compose(x => x * 2);<br/>
        /// int result = parseThenDouble("12"); // 24
        /// </summary>
        public static Func<TIn, TOut> Compose<TIn, TMiddle, TOut>(this Func<TIn, TMiddle> func1, Func<TMiddle, TOut> func2) =>
            value => func2(func1(value));
    }
}