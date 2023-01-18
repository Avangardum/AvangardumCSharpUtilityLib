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
}