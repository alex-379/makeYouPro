namespace ProjectArraysMultidimensional;
public static class OperationsWithArraysMultidimensional
{
    public static int[,] Generate(int row, int column, int left, int right)
    {
        int[,] array = new int[row, column];
        Random random = new();

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(left, right);
            }
        }

        return array;
    }

    public static void Write(int[] array, string nameArray)
    {
        Console.Write($"{nameArray}:");

        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("{0}", array[i]);
        }
        Console.WriteLine();
    }

    public static void Write(int[,] array, string nameArray)
    {
        Console.Write($"{nameArray}:\n");

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

    public static int GetMinElementArray(int[,] array, out int[] minIndex)
    {
        Console.WriteLine();

        int min = array[0, 0];
        minIndex = new int [2];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (min > array[i, j])
                {
                    min = array[i, j];
                    minIndex[0] = j;
                    minIndex[1] = i;
                }
            }
        }

        return min;
    }

    public static int GetMaxElementArray(int[,] array, out int[] maxIndex)
    {
        Console.WriteLine();

        int max = array[0, 0];
        maxIndex = new int[2];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (max < array[i, j])
                {
                    max = array[i, j];
                    maxIndex[0] = j;
                    maxIndex[1] = i;
                }
            }
        }

        return max;
    }

    public static int GetCountElementsMoreLeftAndDown(int[,] array)
    {
        Console.WriteLine();

        int count = 0;

        for (int i = 0; i < array.GetLength(0)-1; i++)
        {
            for (int j = 1; j < array.GetLength(1); j++)
            {
                if (array[i, j] > array[i+1, j] &&
                    array[i, j] > array[i, j-1])
                {
                    count++;
                }
            }
        }

        return count;
    }
}