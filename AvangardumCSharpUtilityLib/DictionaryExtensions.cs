using System;
using System.Collections.Generic;
using System.Linq;

namespace Avangardum.AvangardumCSharpUtilityLib
{
    public static class DictionaryExtensions
    {
        public static TKey GetKey<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TValue value)
        {
            var matchingValuesCount = dictionary.Values.Count(v => Equals(v, value));
            if (matchingValuesCount != 1)
            {
                throw new InvalidOperationException($"GetKey should be called only when there is exactly 1 " +
                                                    $"matching value in the dictionary. Values matched: {matchingValuesCount}.");
            }
        
            return dictionary.Single(p => Equals(p.Value, value)).Key;
        }
    }
}