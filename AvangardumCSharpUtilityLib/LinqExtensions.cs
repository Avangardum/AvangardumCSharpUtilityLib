namespace Avangardum.AvangardumCSharpUtilityLib;

public static class LinqExtensions
{
    #region Product

    public static int Product(this IEnumerable<byte> numbers) => numbers.Aggregate(1, (a, b) => a * b);
    
    public static int Product(this IEnumerable<sbyte> numbers) => numbers.Aggregate(1, (a, b) => a * b);
    
    public static int Product(this IEnumerable<short> numbers) => numbers.Aggregate(1, (a, b) => a * b);
    
    public static int Product(this IEnumerable<ushort> numbers) => numbers.Aggregate(1, (a, b) => a * b);
    
    public static int Product(this IEnumerable<int> numbers) => numbers.Aggregate(1, (a, b) => a * b);
    
    public static uint Product(this IEnumerable<uint> numbers) => numbers.Aggregate(1u, (a, b) => a * b);
    
    public static long Product(this IEnumerable<long> numbers) => numbers.Aggregate(1L, (a, b) => a * b);
    
    public static ulong Product(this IEnumerable<ulong> numbers) => numbers.Aggregate(1ul, (a, b) => a * b);
    
    public static nint Product(this IEnumerable<nint> numbers) => numbers.Aggregate((nint)1, (a, b) => a * b);
    
    public static nuint Product(this IEnumerable<nuint> numbers) => numbers.Aggregate((nuint)1, (a, b) => a * b);
    
    public static float Product(this IEnumerable<float> numbers) => numbers.Aggregate(1f, (a, b) => a * b);
    
    public static double Product(this IEnumerable<double> numbers) => numbers.Aggregate(1d, (a, b) => a * b);
    
    public static decimal Product(this IEnumerable<decimal> numbers) => numbers.Aggregate(1m, (a, b) => a * b);

    #endregion
}