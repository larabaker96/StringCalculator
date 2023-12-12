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

    [TestCase(@"//;\n1;2")]
    [Test]
    public void Given_CustomDelimterOfOneCharacter_When_Adding_Returns_SumOfThoseNumbers(string value)
    {
        var calculatedOutput = _calculator.Add(value);

        Assert.AreEqual(3, calculatedOutput);
    }

    [TestCase("-1,2,-3")]
    [Test]
    public void Given_NegativeNumbers_When_Adding_Returns_Exception(string value)
    {
        var exception = Assert.Throws<Exception>(() => _calculator.Add(value));
        Assert.That(exception.Message, Is.EqualTo("Negatives not allowed: -1,-3"));
    }

    [TestCase("2,1001")]
    [Test]
    public void Given_NumberLargerThanThousand_When_Adding_Returns_SumOfNumbersSmallerThanThousand(string value)
    {
        var calculatedOutput = _calculator.Add(value);

        Assert.AreEqual(2, calculatedOutput);
    }

    [TestCase("//***\\n1***2***3")]
    [Test]
    public void Given_LengthyDelimiter_When_Adding_Returns_SumOfThoseNumbers(string value)
    {
        var calculatedOutput = _calculator.Add(value);

        Assert.AreEqual(6, calculatedOutput);
    }

    [TestCase(@"//[*][%]\n1*2%3")]
    [Test]
    public void Given_MultipleDelimiters_When_Adding_Returns_SumOfThoseNumbers(string value)
    {
        var calculatedOutput = _calculator.Add(value);

        Assert.AreEqual(6, calculatedOutput);
    }

    [TestCase(@"//[***][%]\n1***2%3")]
    [Test]
    public void Given_MultipleLengthyDelimiters_When_Adding_Returns_SumOfThoseNumbers(string value)
    {
        var calculatedOutput = _calculator.Add(value);

        Assert.AreEqual(6, calculatedOutput);
    }
}
