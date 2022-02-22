using System;

class MultiCalculator
{
    static void Main()
    {
        UserInput input = new UserInput();
        Calculations calc = new Calculations();

        string[] calcModes = { "1 - Addition", "2 - Subtraction", "3 - Multiplication", "4 - Division", "5 - Exponentiation" };
        int modeSelect = 0;

        Console.WriteLine("What kind of calculation do you want to do?");

        for (int i = 0; i < calcModes.Length; i++)
        {
            Console.WriteLine(calcModes[i]);
        }

        do
        {
            modeSelect = input.getInt("Enter the number of the calculation mode you wish to use: ");

            switch (modeSelect)
            {
                case 1:
                    Console.WriteLine("Let's add two numbers together");

                    decimal term1 = input.getDecimal("Enter the first number: ");
                    decimal term2 = input.getDecimal("Enter the second number: ");

                    decimal sum = calc.addNums(term1, term2);
                    Console.WriteLine("({0})+({1})=({2})", term1, term2, sum);
                    break;
                case 2:
                    Console.WriteLine("Let's subtracte a number from a different number!");

                    decimal minuend = input.getDecimal("Enter the number you want to subtract from: ");
                    decimal subtrahend = input.getDecimal("Enter the number you want to subtract: ");

                    decimal difference = calc.subtractNums(minuend, subtrahend);
                    Console.WriteLine("({0})-({1})=({2})", minuend, subtrahend, difference);
                    break;
                case 3:
                    Console.WriteLine("Let's multiply two numbers!");

                    decimal factor1 = input.getDecimal("Enter the first factor: ");
                    decimal factor2 = input.getDecimal("Enter the second factor: ");

                    decimal product = calc.multiplyNums(factor1, factor2);
                    Console.WriteLine("({0})*({1})=({2})", factor1, factor2, product);
                    break;
                case 4:
                    Console.WriteLine("Let's divide a number with a different number!");

                    decimal dividend = input.getDecimal("Enter the number you want to divide: ");
                    decimal divisor = 0.0m;
                    bool error = false;

                    do
                    {
                        divisor = input.getDecimal("Enter the number to divide with: ");
                        if (divisor != 0)
                        {
                            error = false;
                        }
                        else
                        {
                            Console.WriteLine("Don't divide by 0! Try again!");
                            error = true;
                        }
                    } while (error);

                    decimal quotient = calc.divideNums(dividend, divisor);
                    Console.WriteLine("({0})/({1})=({2})", dividend, divisor, quotient);

                    break;
                case 5:
                    Console.WriteLine("Let's raise a number to the power of an exponent!");

                    decimal expBase = input.getDecimal("Enter the base: ");
                    int exponent = input.getInt("Enter the exponent: ");

                    decimal power = calc.intExpoNums(expBase, exponent);
                    Console.WriteLine("({0})^({1})=({2})", expBase, exponent, power);
                    break;
                default:
                    Console.WriteLine("Sorry there are only {0} modes implemented so far! Please try again!", calcModes.Length);
                    modeSelect = 0;
                    break;
            }
        } while (modeSelect == 0);

        exit();
    }
    static void exit()
    {
        Console.Write("\nPress any key to exit!");
        Console.ReadKey(true);
    }
}
public class Calculations
{
    public decimal addNums(decimal term1, decimal term2)
    {
        decimal sum = term1 + term2;
        return sum;
    }
    public decimal subtractNums(decimal minuend, decimal subtrahend)
    {
        decimal difference = minuend - subtrahend;
        return difference;
    }
    public decimal multiplyNums(decimal factor1, decimal factor2)
    {
        decimal product = factor1 * factor2;
        return product;
    }

    public decimal divideNums(decimal dividend, decimal divisor)
    {
        decimal quotient = dividend / divisor;
        return quotient;
    }
    public decimal intExpoNums(decimal expBase, int exponent)
    {
        decimal power = expBase;
        for (int i = 1; i < exponent; i++) power *= expBase;
        return power;
    }
}
public class UserInput
{
    private bool error = false;
    private String invalidInput = "Invalid input, please try again!";
    private String tempString = "";

    public string getString(string prompt)
    {
        string result = "";

        do
        {
            Console.Write(prompt);
            error = false;
            result = Console.ReadLine();
            if (result == "")
            {
                Console.WriteLine("Please don't leave the string empty!");
                error = true;
            }
        } while (error);

        return result;
    }
    public decimal getDecimal(string prompt)
    {
        decimal result = 0.0m;

        do
        {
            tempString = getString(prompt);
            error = false;
            try
            {
                result = decimal.Parse(tempString);
            }
            catch
            {
                Console.WriteLine(invalidInput);
                error = true;
            }
        } while (error);

        return result;
    }
    public int getInt(string prompt)
    {
        int result = 0;

        do
        {
            tempString = getString(prompt);
            error = false;
            try
            {
                result = Int32.Parse(tempString);
            }
            catch
            {
                Console.WriteLine(invalidInput);
                error = true;
            }
        } while (error);

        return result;
    }
}