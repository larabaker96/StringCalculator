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

    [TestCase ("")]
    [Test]
    public void Given_EmptyString_Returns_Zero(string value)
    {
        var calculatedOutput = _calculator.Add(value);

        Assert.AreEqual(0, calculatedOutput);
    }

    [TestCase("1")]
    [Test]
    public void Given_SingleNumber_When_Adding_Returns_ThatNumber(string value)
    {
        var calculatedOutput = _calculator.Add(value);

        Assert.AreEqual(1, calculatedOutput);
    }

    [TestCase("1,2")]
    [Test]
    public void Given_TwoNumbers_When_Adding_Returns_SumOfThoseNumbers(string value)
    {
        var calculatedOutput = _calculator.Add(value);

        Assert.AreEqual(3, calculatedOutput);
    }

    [TestCase("1,2,3,4,5")]
    [Test]
    public void Given_UnknownAmountOfNumbers_When_Adding_Returns_SumOfThoseNumbers(string value)
    {
        var calculatedOutput = _calculator.Add(value);

        Assert.AreEqual(15, calculatedOutput);
    }

    [TestCase(@"1\n2,3")]
    [Test]
    public void Given_NewLineBetweenNumbers_When_Adding_Returns_SumOfThoseNumbers(string value)
    {
        var calculatedOutput = _calculator.Add(value);

        Assert.AreEqual(6, calculatedOutput);
    }
}
