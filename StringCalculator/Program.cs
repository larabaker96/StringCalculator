﻿// See https://aka.ms/new-console-template for more information
using StringCalculator;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Task 1: Please insert a string of up to 2 numbers");

        //string input = Console.ReadLine();

        //int result = Calculator.Add1(input);

        //Console.WriteLine("Sum of string is: " + result);

        //Console.WriteLine("Task 2: Please insert a string of any numbers");

        //string input2 = Console.ReadLine();

        //int result2 = Calculator.Add2(input2);

        //Console.WriteLine("Sum of string is: " + result2);

        //Console.WriteLine("Task 3: Please insert a string of any numbers");

        //string input3 = Console.ReadLine();

        //int result3 = Calculator.Add3(input3);

        //Console.WriteLine("Sum of string is: " + result3);

        //Console.WriteLine(@"Task 4: Please insert a string of any numbers, you can specify the delimiter by inserting //Delimeter\n before.");

        //string input4 = Console.ReadLine();

        //int result4 = Calculator.Add4(input4);

        //Console.WriteLine("Sum of string is: " + result4);

        //Console.WriteLine(@"Task 5: Please insert a string of any numbers, you can specify the delimiter by inserting //Delimeter\n before.");

        //string input5 = Console.ReadLine();

        //try
        //{
        //    int result5 = Calculator.Add5(input5);

        //    Console.WriteLine("Sum of string is: " + result5);
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}

        Console.WriteLine(@"Task 6: Please insert a string of any numbers, you can specify the delimiter by inserting //Delimeter\n before.");

        try
        {
            string input6 = Console.ReadLine();

            int result6 = Calculator.Add6(input6);

            Console.WriteLine("Sum of string is: " + result6);
        } catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }


    }
}