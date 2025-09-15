using Shared;

try
{

    var n = ConsoleExtensions.getInt("Enter the size of the matrix (positive integer): ");

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
            if ((j < i && i + j <= 9) || (i < j && i + j >= 11))
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
