using System;

namespace UserInput;

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
    public void exit()
    {
        Console.Write("\nPress any key to exit!");
        Console.ReadKey(true);
    }
}