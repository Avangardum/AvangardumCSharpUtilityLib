namespace Avangardum.AvangardumCSharpUtilityLib.Tests;

public class AvRandomTests
{
    [TestCase(0, 0, 0)]
    [TestCase(1, 1000000, 1000000)]
    [TestCase(0.1, 90000, 110000)]
    [TestCase(0.5, 490000, 510000)]
    [TestCase(0.8, 790000, 810000)]
    public void NextBool_Call1MTimesWithGivenProbability_TrueReturnCountIsInGivenRange(double probability, 
        int minTrueReturnCount, int maxTrueReturnCount)
    {
        int trueReturnCount = 0;
        for (int i = 0; i < 1000000; i++)
        {
            var result = AvRandom.NextBool(probability);
            if (result) trueReturnCount++;
        }
        Assert.That(trueReturnCount, Is.InRange(minTrueReturnCount, maxTrueReturnCount));
    }

    [Test]
    public void NextBool_Call1MTimesWithoutProbability_ReturnTrueFrom490KTo510KTimes()
    {
        int trueReturnCount = 0;
        for (int i = 0; i < 1000000; i++)
        {
            var result = AvRandom.NextBool();
            if (result) trueReturnCount++;
        }
        Assert.That(trueReturnCount, Is.InRange(490000, 510000));
    }
}