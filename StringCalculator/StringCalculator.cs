namespace StringCalculator
{
    public class StringCalculator
    {
        public int Add(string numbersGiven)
        {
            int finalResult = 0;

            string numbersToCalculate = numbersGiven;

            if (String.IsNullOrEmpty(numbersToCalculate))
            {
                return 0;
            }

            return finalResult;
        }
    }
}
