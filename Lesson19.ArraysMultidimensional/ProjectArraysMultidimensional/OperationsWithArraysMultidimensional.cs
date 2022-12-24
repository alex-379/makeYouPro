namespace ProjectArraysMultidimensional;
public static class OperationsWithArraysMultidimensional
{
    public static int[,] Generate(int column, int row, int left, int right)
    {
        int[,] array = new int[column, row];
        Random random= new();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(left, right);
            }
        }

        return array;
    }

    public static void Write(int[,] array, string nameResult)
    {
        Console.Write($"{nameResult}:\n");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("{0} ", array[i, j]);
            }
            Console.WriteLine();
        }
    }

    public static void Write(int result, string nameResult)
    {
        Console.WriteLine($"{nameResult}: {result}\n");
    }
}
