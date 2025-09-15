namespace Shared;

public class ConsoleExtensions
{

    public static int getInt(string message)
    {
        
        Console.Write(message);
        var input = Console.ReadLine();

        if (int.TryParse(input, out int result) && result > 0)
        {
            return result;
        }

        throw new Exception($"The value {result} is not valid. Please enter a positive integer.");
   
    }

    public static int getOddInt(string message)
    {

        Console.Write(message);
        var input = Console.ReadLine();

        if (int.TryParse(input, out int result) && result > 0 && result % 2 != 0)
        {
            return result;
        }

        throw new Exception($"The value {result} is not valid. Please enter a positive odd integer.");

    }

}
