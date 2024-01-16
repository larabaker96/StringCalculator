using NUnit.Framework;

namespace StringCalculator.Tests
{
    public class StringCalculatorTests
    {
        private StringCalculator _calculator = null!;

        [SetUp]
        public void Setup()
        {
            _calculator = new StringCalculator();
        }

        [Test]
        public void Given_EmptyString_Returns_Zero()
        {
            string testInput = "";
            int expectedOutput = 0;

            int calculatedOutput = _calculator.Add(testInput);

            Assert.AreEqual(expectedOutput, calculatedOutput);
        }

        [Test]
        public void Given_SingleNumber_When_Adding_Returns_ThatNumber()
        {
            string testInput = "1";
            int expectedOutput = 1;

            int calculatedOutput = _calculator.Add(testInput);

            Assert.AreEqual(expectedOutput, calculatedOutput);
        }

        [Test]
        public void Given_TwoNumbers_When_Adding_Returns_SumOfThoseNumbers()
        {
            string testInput = "1,2";
            int expectedOutput = 3;

            int calculatedOutput = _calculator.Add(testInput);

            Assert.AreEqual(expectedOutput, calculatedOutput);
        }

        [Test]
        public void Given_UnknownNumbers_When_Adding_Returns_SumOfThoseNumbers()
        {
            string testInput = "1,2,3,4,5";
            int expectedOutput = 15;

            int calculatedOutput = _calculator.Add(testInput);
            Assert.AreEqual(expectedOutput, calculatedOutput);
        }

        [Test]
        public void Given_UnknownNumbersAndNewLines_When_Adding_Returns_SumOfThoseNumbers()
        {
            string testInput = @"1\n2,3";
            int expectedOutput = 6;

            int calculatedOutput = _calculator.Add(testInput);
            Assert.AreEqual(expectedOutput, calculatedOutput);
        }
    }
}
