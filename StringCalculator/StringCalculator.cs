namespace StringCalculator
{
    public class StringCalculator
    {
        private const int maxNumberToAdd = 1000;

        public int Add(string numbersGiven)
        {
            string[] seperators = new string[] { ",", "\\n" };

            if (String.IsNullOrEmpty(numbersGiven))
            {
                return 0;
            }

            String[] splitNumbersToAdd = numbersGiven.Split(seperators, StringSplitOptions.None);

            int finalResult = CalculateSplitNumberAddition(splitNumbersToAdd);

            return finalResult;
        }

        private int CalculateSplitNumberAddition(string[] splitNumbersToAdd)
        {
            int splitNumbersAdded = 0;

            foreach (string currentNumber in splitNumbersToAdd)
            {
                int convertedCurrentNumber = Convert.ToInt32(currentNumber);

                splitNumbersAdded += convertedCurrentNumber;
            }

            return splitNumbersAdded;
        }
    }
}
