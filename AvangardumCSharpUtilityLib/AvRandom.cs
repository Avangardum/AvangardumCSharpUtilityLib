using System;

namespace Avangardum.AvangardumCSharpUtilityLib
{
    public class AvRandom
    {
        private static readonly Random Random = new Random();

        public static bool NextBool(double probability = 0.5) => probability > Random.NextDouble();
    }
}