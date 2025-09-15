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

        throw new Exception($"The value {result} is not valid. Please enter a positive integer. Try again.");
   
    }
}
