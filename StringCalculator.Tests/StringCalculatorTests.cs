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

            var calculatedOutput = _calculator.Add(testInput);

            Assert.AreEqual(expectedOutput, calculatedOutput);
        }
    }
}
