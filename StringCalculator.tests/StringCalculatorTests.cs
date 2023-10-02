using NUnit.Framework;

namespace StringCalculator.tests;
public class StringCalculatorTests
{
    private StringCalculator _calculator = null!;

    [SetUp]
    public void Setup()
    {
        _calculator = new StringCalculator();
    }

    [TearDown]
    public void Teardown() 
    {
        
    }

    [TestCase ("")]
    [Test]
    public void returnZeroOnEmptyString(string value)
    {
        var calculatedOutput = _calculator.Add(value);

        Assert.AreEqual(0, calculatedOutput);
    }

}
