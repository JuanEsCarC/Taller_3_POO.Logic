using Shared;

var response = string.Empty;

do
{
    try
    {

        var n = ConsoleExtensions.getOddInt("Enter the size of the matrix (positive odd integer): ");

        int?[,] celda = new int?[n, n];


        for (int i = 0; i < n; i++)
        {
            int start = 2 * i;
            
            for (int j = 0; j < n; j++)
            {
                celda[i, j] = start + j;
            }
        }

        Console.WriteLine("FULL MATRIX");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{celda[i, j],-5}");
            }
            Console.WriteLine();
        }

        Console.WriteLine("HOURGLASS");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int midPoint = (n - 1) / 2;

                if ((j < i && i + j <= (midPoint * 2 - 1)) || (i < j && i + j >= (midPoint * 2 + 1)))
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
