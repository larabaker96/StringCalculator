using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class Calculator
    {
        public static int Add1(string numbers)
        {
            int result = 0;

            if(numbers != "")
            {
                foreach (string number in numbers.Split(","))
                {
                    result += Convert.ToInt32(number);
                }

            }

            return result;
        }

        //Same as number 1 as used a method in string 1 that didnt restrict me to 2 numbers
        public static int Add2(string numbers)
        {
            int result = 0;

            if (numbers != "")
            {
                foreach (string number in numbers.Split(","))
                {
                    result += Convert.ToInt32(number);
                }

            }

            return result;
        }

        public static int Add3(string numbers)
        {
            int result = 0;

            if (numbers != "")
            {
                string[] seperators = new string[] { ",", "\\n" };
                foreach (string number in numbers.Split(seperators, StringSplitOptions.None))
                {
                    result += Convert.ToInt32(number);
                }

            }

            return result;
        }

        public static int Add4(string numbers)
        {
            int result = 0;

            if (numbers != "")
            {
                string[] seperators = new string[] { ",", "\\n" };

                //You want to check if it must start with // and then change the delimeters before the new line
                //and then make numbers the value after the first \n
                if (numbers.StartsWith("//"))
                {
                    seperators = new string[] { numbers[2].ToString() };

                    numbers = numbers.Substring(numbers.IndexOf("\\n") + 2);
                }

                foreach (string number in numbers.Split(seperators, StringSplitOptions.None))
                {
                    result += Convert.ToInt32(number);
                }

            }

            return result;
        }

        public static int Add5(string numbers)
        {
            int result = 0;

            if (numbers != "")
            {
                string[] seperators = new string[] { ",", "\\n" };

                if (numbers.StartsWith("//"))
                {
                    seperators = new string[] { numbers[2].ToString() };

                    numbers = numbers.Substring(numbers.IndexOf("\\n") + 2);
                }

                List<string> negatives = new List<string>();
                foreach (string number in numbers.Split(seperators, StringSplitOptions.None))
                {
                    if (Convert.ToInt32(number) > 0)
                    {
                        result += Convert.ToInt32(number);
                    }
                    else if (Convert.ToInt32(number) < 0)
                    {
                        negatives.Add(number);
                    }
                }

                if (negatives.Count > 0)
                {
                    string message = "No negatives allowed: " + String.Join(",", negatives);
                    throw new Exception(message);
                }
            }

            return result;
        }

        public static int Add6(string numbers)
        {
            int result = 0;

            if (numbers != "")
            {
                string[] seperators = new string[] { ",", "\\n" };

                if (numbers.StartsWith("//"))
                {
                    seperators = new string[] { numbers[2].ToString() };

                    numbers = numbers.Substring(numbers.IndexOf("\\n") + 2);
                }

                List<string> negatives = new List<string>();
                foreach (string number in numbers.Split(seperators, StringSplitOptions.None))
                {
                    if (Convert.ToInt32(number) > 0 && Convert.ToInt32(number) <= 1000)
                    {
                        result += Convert.ToInt32(number);
                    }
                    else if (Convert.ToInt32(number) < 0)
                    {
                        negatives.Add(number);
                    }
                }

                if (negatives.Count > 0)
                {
                    string message = "No negatives allowed: " + String.Join(",", negatives);
                    throw new Exception(message);
                }

            }

            return result;
        }

        public static int Add7(string numbers)
        {
            int result = 0;

            if (numbers != "")
            {
                string[] seperators = new string[] { ",", "\\n" };

                if (numbers.StartsWith("//"))
                {
                    //substring from two to \n
                    string seperator = numbers[2..numbers.IndexOf("\\n")];
                    seperators = new string[] { seperator };

                    numbers = numbers.Substring(numbers.IndexOf("\\n") + 2);
                }

                List<string> negatives = new List<string>();
                foreach (string number in numbers.Split(seperators, StringSplitOptions.None))
                {
                    if (Convert.ToInt32(number) > 0 && Convert.ToInt32(number) <= 1000)
                    {
                        result += Convert.ToInt32(number);
                    }
                    else if (Convert.ToInt32(number) < 0)
                    {
                        negatives.Add(number);
                    }
                }

                if (negatives.Count > 0)
                {
                    string message = "No negatives allowed: " + String.Join(",", negatives);
                    throw new Exception(message);
                }

            }

            return result;
        }

        public static int Add8(string numbers)
        {
            int result = 0;

            if (numbers != "")
            {
                string[] seperators = new string[] { ",", "\\n" };

                if (numbers.StartsWith("//"))
                {
                    //substring from two to \n
                    string seperatorList = numbers[2..numbers.IndexOf("\\n")];

                    //we want to split the list into the different square bracket pairs
                    //we use RemoveEmptyEntries for the empty array objects between the brackets - otherwise the result would be "","delim1","","delim2","" etc
                    seperators = seperatorList.Split(new string[] { "[", "]" }, StringSplitOptions.RemoveEmptyEntries);

                    numbers = numbers.Substring(numbers.IndexOf("\\n") + 2);
                }

                List<string> negatives = new List<string>();
                foreach (string number in numbers.Split(seperators, StringSplitOptions.None))
                {
                    if (Convert.ToInt32(number) > 0 && Convert.ToInt32(number) <= 1000)
                    {
                        result += Convert.ToInt32(number);
                    }
                    else if (Convert.ToInt32(number) < 0)
                    {
                        negatives.Add(number);
                    }
                }

                if (negatives.Count > 0)
                {
                    string message = "No negatives allowed: " + String.Join(",", negatives);
                    throw new Exception(message);
                }

            }

            return result;
        }

        //Same as number 8 because we didnt restrict the characters in the delimeter
        public static int Add9(string numbers)
        {
            int result = 0;

            if (numbers != "")
            {
                string[] seperators = new string[] { ",", "\\n" };

                if (numbers.StartsWith("//"))
                {
                    //substring from two to \n
                    string seperatorList = numbers[2..numbers.IndexOf("\\n")];

                    //we want to split the list into the different square bracket pairs
                    //we use RemoveEmptyEntries for the empty array objects between the brackets, otherwise the result would be "", "delim1", "", "delim2", "" etc
                    seperators = seperatorList.Split(new string[] { "[", "]" }, StringSplitOptions.RemoveEmptyEntries);

                    numbers = numbers.Substring(numbers.IndexOf("\\n") + 2);
                }

                List<string> negatives = new List<string>();
                foreach (string number in numbers.Split(seperators, StringSplitOptions.None))
                {
                    if (Convert.ToInt32(number) > 0 && Convert.ToInt32(number) <= 1000)
                    {
                        result += Convert.ToInt32(number);
                    }
                    else if (Convert.ToInt32(number) < 0)
                    {
                        negatives.Add(number);
                    }
                }

                if (negatives.Count > 0)
                {
                    string message = "No negatives allowed: " + String.Join(",", negatives);
                    throw new Exception(message);
                }

            }

            return result;
        }
    }
}
