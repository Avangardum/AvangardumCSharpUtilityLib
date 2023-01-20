namespace Avangardum.AvangardumCSharpUtilityLib.Tests;

public class LinqExtensionsTests
{
    #region Product

    [Test]
    public void Product_2And3And4Byte_24()
    {
        var numbers = new List<byte> { 2, 3, 4 };
        var result = numbers.Product();
        Assert.That(result, Is.EqualTo(24));
    }
    
    [Test]
    public void Product_2And3And4Sbyte_24()
    {
        var numbers = new List<sbyte> { 2, 3, 4 };
        var result = numbers.Product();
        Assert.That(result, Is.EqualTo(24));
    }
    
    [Test]
    public void Product_2And3And4Short_24()
    {
        var numbers = new List<short> { 2, 3, 4 };
        var result = numbers.Product();
        Assert.That(result, Is.EqualTo(24));
    }
    
    [Test]
    public void Product_2And3And4Ushort_24()
    {
        var numbers = new List<ushort> { 2, 3, 4 };
        var result = numbers.Product();
        Assert.That(result, Is.EqualTo(24));
    }
    
    [Test]
    public void Product_2And3And4Int_24()
    {
        var numbers = new List<int> { 2, 3, 4 };
        var result = numbers.Product();
        Assert.That(result, Is.EqualTo(24));
    }
    
    [Test]
    public void Product_2And3And4Uint_24()
    {
        var numbers = new List<uint> { 2, 3, 4 };
        var result = numbers.Product();
        Assert.That(result, Is.EqualTo(24));
    }
    
    [Test]
    public void Product_2And3And4Long_24()
    {
        var numbers = new List<long> { 2, 3, 4 };
        var result = numbers.Product();
        Assert.That(result, Is.EqualTo(24));
    }
    
    [Test]
    public void Product_2And3And4Ulong_24()
    {
        var numbers = new List<ulong> { 2, 3, 4 };
        var result = numbers.Product();
        Assert.That(result, Is.EqualTo(24));
    }
    
    [Test]
    public void Product_2And3And4Nint_24()
    {
        var numbers = new List<nint> { 2, 3, 4 };
        var result = numbers.Product();
        Assert.That(result, Is.EqualTo((nint)24));
    }
    
    [Test]
    public void Product_2And3And4Nuint_24()
    {
        var numbers = new List<nuint> { 2, 3, 4 };
        var result = numbers.Product();
        Assert.That(result, Is.EqualTo((nuint)24));
    }
    
    [Test]
    public void Product_2And3And4Float_24()
    {
        var numbers = new List<float> { 2, 3, 4 };
        var result = numbers.Product();
        Assert.That(result, Is.EqualTo(24));
    }
    
    [Test]
    public void Product_2And3And4Double_24()
    {
        var numbers = new List<double> { 2, 3, 4 };
        var result = numbers.Product();
        Assert.That(result, Is.EqualTo(24));
    }
    
    [Test]
    public void Product_2And3And4Decimal_24()
    {
        var numbers = new List<decimal> { 2, 3, 4 };
        var result = numbers.Product();
        Assert.That(result, Is.EqualTo(24));
    }

    #endregion

    [Test]
    public void Random_1And2And4And4Run1000000Times_ReturnsEveryNumber200000To300000Times()
    {
        IEnumerable<int> numbers = new List<int> { 1, 2, 3, 4 };
        Dictionary<int, int> randomRollCounts = new Dictionary<int, int> { [1] = 0, [2] = 0, [3] = 0, [4] = 0 };
        for (int i = 0; i < 1000000; i++)
        {
            var result = numbers.Random();
            randomRollCounts[result]++;
        }
        Assert.That(randomRollCounts.Values, Is.All.InRange(200000, 300000));
    }

    [Test]
    public void AsList_List_SameList()
    {
        IEnumerable<int> inputList = new List<int> { 1, 2, 3 };
        var outputList = inputList.AsList();
        Assert.That(ReferenceEquals(inputList, outputList));
    }

    [Test]
    public void AsList_Array_EquivalentList()
    {
        IEnumerable<int> inputArray = new int[] { 1, 2, 3 };
        var outputList = inputArray.AsList();
        Assert.That(outputList, Is.EquivalentTo(inputArray));
    }
}