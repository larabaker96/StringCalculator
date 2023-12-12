namespace StringCalculator;
public class StringCalculator
{
    private string[] seperators = new string[] { ",", "\\n" };
    private List<string> negativeNumbers = new List<string>();
    private int maxNumberToAdd = 1000;
    private int finalResult = 0;

    public int Add(string numbersGiven)
    {
        string numbersToCalculate = numbersGiven;

        if (String.IsNullOrEmpty(numbersToCalculate))
        {
            return 0;
        }

        numbersToCalculate = CheckForSeperators(numbersToCalculate);
        String[] splitNumbersToAdd = numbersToCalculate.Split(seperators, StringSplitOptions.None);

        finalResult = CalculateSplitNumberAddition(splitNumbersToAdd);

        return finalResult;
    }

    private int CalculateSplitNumberAddition(string[] splitNumbersToAdd)
    {
        foreach (string currentNumber in splitNumbersToAdd)
        {
            int convertedCurrentNumber = Convert.ToInt32(currentNumber);

            if (convertedCurrentNumber < 0)
            {
                negativeNumbers.Add(currentNumber);
                continue;
            }
            else if (convertedCurrentNumber > maxNumberToAdd)
            {
                continue;
            }

            finalResult += convertedCurrentNumber;
        }

        if (negativeNumbers.Count > 0)
        {
            string message = "Negatives not allowed: " + String.Join(",", negativeNumbers);
            throw new Exception(message);
        }

        return finalResult;
    }

    private string CheckForSeperators(string numbersToCalculate)
    {
        if (numbersToCalculate.StartsWith("//"))
        {
            string seperatorFromInput = numbersToCalculate[2..numbersToCalculate.IndexOf("\\n")];
            seperators = seperatorFromInput.Split(new string[] { "[", "]" }, StringSplitOptions.RemoveEmptyEntries);

            numbersToCalculate = numbersToCalculate.Substring(numbersToCalculate.IndexOf("\\n") + 2);
        }

        return numbersToCalculate;
    }
}
