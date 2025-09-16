using Shared;

var response = string.Empty;

do
{
    try
    {

        var n = ConsoleExtensions.getInt("Enter the size of the matrix (positive integer): ");

        int?[,] celda = new int?[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                celda[i, j] = i + j;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{celda[i, j],-5}");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j > i)
                {
                    celda[i, j] = null;
                }
                Console.Write($"{celda[i, j],-5}");
            }
            Console.WriteLine();
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.WriteLine();
    Console.Write("Want to try again, [Y]es or [N]ot? ");
    response = Console.ReadLine();

}
while (response!.ToLower() == "y");

Console.WriteLine("Game Over! Thanks for playing");