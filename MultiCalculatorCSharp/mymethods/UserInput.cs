using System;

namespace UserInput;

public class input
{
    private static bool error = false;
    private static String invalidInput = "Invalid input, please try again!";
    private static String tempString = "";

    public static string getString(string prompt)
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
    public static decimal getDecimal(string prompt)
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
    public static int getInt(string prompt)
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
    public static void exit()
    {
        Console.Write("\nPress any key to exit!");
        Console.ReadKey(true);
    }
}