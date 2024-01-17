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
        public void Given_UnknownNumberLength_When_Adding_Returns_SumOfThoseNumbers()
        {
            string testInput = "1,2,3,4,5";
            int expectedOutput = 15;

            int calculatedOutput = _calculator.Add(testInput);

            Assert.AreEqual(expectedOutput, calculatedOutput);
        }

        [Test]
        public void Given_UnknownNumberLengthAndNewLines_When_Adding_Returns_SumOfThoseNumbers()
        {
            string testInput = @"1\n2,3";
            int expectedOutput = 6;

            int calculatedOutput = _calculator.Add(testInput);

            Assert.AreEqual(expectedOutput, calculatedOutput);
        }

        [Test]
        public void Given_NewLines_When_Adding_Returns_Zero()
        {
            string testInput = @"\n\n\n\n";
            int expectedOutput = 0;

            int calculatedOutput = _calculator.Add(testInput);

            Assert.AreEqual(expectedOutput, calculatedOutput);
        }

        [Test]
        public void Given_NumbersAndCustomDelimiterOfOneCharacterLength_When_Adding_Returns_SumOfThoseNumbers()
        {
            string testInput = @"//;\n1;2";
            int expectedOutput = 3;

            int calculatedOutput = _calculator.Add(testInput);

            Assert.AreEqual(expectedOutput, calculatedOutput);
        }

        [Test]
        public void Given_NegativeNumbers_When_Adding_Throws_Exception()
        {
            string testInput = @"-1,2,-3";

            Action addingNegativeNumbers = () => _calculator.Add(testInput);

            Assert.Throws<Exception>(() => addingNegativeNumbers());
        }

        [Test]
        public void Given_NumbersIncludingNumberLargerThanLimit_When_Adding_Returns_SumOfThoseNumbersIgnoringLimit()
        {
            string testInput = "2,1001";
            int expectedOutput = 2;

            int calculatedOutput = _calculator.Add(testInput);

            Assert.AreEqual(expectedOutput, calculatedOutput);
        }

        [Test]
        public void Given_NumbersIncludingNumberEqualToLimit_When_Adding_Returns_SumOfThoseNumbersIgnoringLimit()
        {
            string testInput = "2,1000";
            int expectedOutput = 1002;

            int calculatedOutput = _calculator.Add(testInput);

            Assert.AreEqual(expectedOutput, calculatedOutput);
        }

        [Test]
        public void Given_NumbersAndCustomDelimiterOfMultipleCharacters_When_Adding_Returns_SumOfThoseNumbers()
        {
            string testInput = @"//***\n1***2***3";
            int expectedOutput = 6;

            int calculatedOutput = _calculator.Add(testInput);

            Assert.AreEqual(expectedOutput, calculatedOutput);
        }

        [Test]
        public void Given_NumbersAndMultipleCustomDelimiters_When_Adding_Returns_SumOfThoseNumbers()
        {
            string testInput = @"//[*][%]\n1*2%3";
            int expectedOutput = 6;

            int calculatedOutput = _calculator.Add(testInput);

            Assert.AreEqual(expectedOutput, calculatedOutput);
        }
    }
}
