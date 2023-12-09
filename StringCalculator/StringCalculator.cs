namespace StringCalculator;
public class StringCalculator
{
    private string[] seperators = new string[] { ",", "\\n" };

    public int Add(string numbersToCalculate)
    {
        int finalResult = 0;

        if (String.IsNullOrEmpty(numbersToCalculate))
        {
            return 0;
        }

        String[] splitNumbersToAdd = numbersToCalculate.Split(seperators, StringSplitOptions.None);

        foreach (string currentNumber in splitNumbersToAdd)
        {
            finalResult += Convert.ToInt32(currentNumber);
        }

        return finalResult;
    }
}
