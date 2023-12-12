namespace StringCalculator;
public class StringCalculator
{
    private string[] seperators = new string[] { ",", "\\n" };
    private List<string> negativeNumbers = new List<string>();

    public int Add(string numbersGiven)
    {
        string numbersToCalculate = numbersGiven;
        int finalResult = 0;

        if (String.IsNullOrEmpty(numbersToCalculate))
        {
            return 0;
        }

        numbersToCalculate = CheckForSeperators(numbersToCalculate);
        String[] splitNumbersToAdd = numbersToCalculate.Split(seperators, StringSplitOptions.None);

        foreach (string currentNumber in splitNumbersToAdd)
        {
            if (Convert.ToInt32(currentNumber) < 0)
            {
                negativeNumbers.Add(currentNumber);
                continue;
            }
            else if (Convert.ToInt32(currentNumber) > 1000)
            {
                continue;
            }

            finalResult += Convert.ToInt32(currentNumber);
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
