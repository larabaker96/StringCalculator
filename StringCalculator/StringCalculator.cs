namespace StringCalculator
{
    public class StringCalculator
    {
        private const int maxNumberToAdd = 1000;

        public int Add(string numbersGiven)
        {
            if (string.IsNullOrEmpty(numbersGiven))
            {
                return 0;
            }

            string[] splitNumbersToAdd = SplitStringWithDefaultOrCustomSeperators(numbersGiven);

            ValidateNumbersForNegatives(splitNumbersToAdd);

            string[] splitAndFilteredNumbers = FilterNumbersToSumUnderLimit(splitNumbersToAdd);

            int finalResult = CalculateSplitNumberAddition(splitAndFilteredNumbers);

            return finalResult;
        }

        private string[] SplitStringWithDefaultOrCustomSeperators(string numbersToSplit)
        {
            string numbersToCheckForSeperstors = numbersToSplit;

            string[] seperators = new string[] { ",", "\\n" };

            if (numbersToCheckForSeperstors.StartsWith("//"))
            {
                string seperatorFromInput = numbersToSplit[2..numbersToSplit.IndexOf("\\n")];
                seperators = seperatorFromInput.Split(new string[] { "[", "]" }, StringSplitOptions.RemoveEmptyEntries);

                numbersToCheckForSeperstors = numbersToSplit.Substring(numbersToSplit.IndexOf("\\n") + 2);
            }

            string[] numbersSplit = numbersToCheckForSeperstors.Split(seperators, StringSplitOptions.None);

            return numbersSplit;
        }

        private void ValidateNumbersForNegatives(string[] numbersToValidate)
        {
            List<string> negativeNumbers = new List<string>();

            foreach (string currentNumber in numbersToValidate)
            {
                if (string.IsNullOrEmpty(currentNumber))
                {
                    continue;
                }

                int convertedCurrentNumber = Convert.ToInt32(currentNumber);

                if (convertedCurrentNumber < 0)
                {
                    negativeNumbers.Add(currentNumber);                   
                }
            }

            if (negativeNumbers.Count > 0)
            {
                string message = "Negatives not allowed: " + string.Join(",", negativeNumbers);
                throw new Exception(message);
            }
        }

        public string[] FilterNumbersToSumUnderLimit(string[] numbersToFilter)
        {
            string[] numbersFiltered = numbersToFilter.
                Where(filterCheck => !string.IsNullOrEmpty(filterCheck) && Convert.ToInt32(filterCheck) <= maxNumberToAdd)
                .ToArray();
            return numbersFiltered;
        }

        private int CalculateSplitNumberAddition(string[] splitAndFilteredNumbersToAdd)
        {
            int splitNumbersAddedUp = 0;

            foreach (string currentNumber in splitAndFilteredNumbersToAdd)
            {
                if (string.IsNullOrEmpty(currentNumber))
                {
                    continue;
                }

                int convertedCurrentNumber = Convert.ToInt32(currentNumber);

                splitNumbersAddedUp += convertedCurrentNumber;
            }

            return splitNumbersAddedUp;
        }

    }
}
