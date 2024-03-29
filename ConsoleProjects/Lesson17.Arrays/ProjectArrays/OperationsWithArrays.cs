﻿namespace ProjectArrays;

public static class OperationsWithArrays
{
    public static int ReadLengthFromConsole()
    {
        int n = 0;
        bool isNumberInt = false;
        while (!isNumberInt || n < 1)
        {
            Console.WriteLine("Введите длину массива:");
            string? s = Console.ReadLine();
            isNumberInt = int.TryParse(s, out n);
            if (!isNumberInt || n < 1)
            {
                Console.WriteLine("Вы ввели некорректные данные.");
            }
        }

        return n;
    }

    public static double[] ReadArrayFromConsole(int length)
    {
        double[] numbers = new double[length];
        for (int i = 0; i < numbers.Length; i++)
        {
            int n = 0;
            int j = i + 1;
            bool isNumber = false;
            while (!isNumber)
            {
                Console.WriteLine($"Введите {j}-й элемент массива:");
                string? s = Console.ReadLine();
                isNumber = int.TryParse(s, out n);
                if (!isNumber)
                {
                    Console.WriteLine("Вы ввели некорректные данные.");
                }
            }
            numbers[i] = n;
        }

        return numbers;
    }

    public static double[] Generate(int number, int left, int right)
    {
        double[] array = new double[number];
        Random random = new();
        for (int i = 0; i < number; i++)
        {
            array[i] = random.Next(left, right);
        }

        return array;
    }

    public static void Write(double result, string nameResult)
    {
        Console.WriteLine($"{nameResult}: {result}\n");
    }

    public static void Write(double[] result, string nameResult)
    {
        Console.Write($"{nameResult}: ");
        for (int i = 0; i < result.Length; ++i)
        {
            Console.Write("{0} ", result[i]);
        }
        Console.WriteLine("\n");
    }

    public static double GetMinElementArray(double[] numbers, out int indexMin)
    {
        indexMin = 0;
        double min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (min > numbers[i])
            {
                min = numbers[i];
                indexMin = i;
            }
        }

        return min;
    }

    public static double GetMaxElementArray(double[] numbers, out int indexMax)
    {
        indexMax = 0;
        double max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (max < numbers[i])
            {
                max = numbers[i];
                indexMax = i;
            }
        }

        return max;
    }

    public static double[] GetElementsArrayWithOddIndexes(double[] numbers)
    {
        double[] indexOdd = new double[numbers.Length / 2];
        int count = 0;
        for (int i = 1; i < numbers.Length; i += 2)
        {
            indexOdd[count] = numbers[i];
            count++;
        }

        return indexOdd;
    }

    public static double GetSumElementsArray(double[] numbers)
    {
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return sum;
    }

    public static double[] ReverseElementsArray(double[] numbers)
    {
        double[] copy = numbers.ToArray();
        double[] numbersReverse = copy;
        for (int i = 0; i < numbers.Length / 2; i++)
        {
            (copy[copy.Length - 1 - i], numbersReverse[i]) =
            (numbersReverse[i], copy[copy.Length - 1 - i]);
        }

        return numbersReverse;
    }

    public static double[] GetOddElementsArray(double[] numbers, out int countOdd)
    {
        double[] accum = new double[numbers.Length];
        countOdd = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            accum[i] = -1;
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 != 0)
            {
                accum[i] = numbers[i];
            }
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            if (accum[i] != -1)
            {
                countOdd++;
            }
        }
        double[] numbersOdd = new double[countOdd];
        int j = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (accum[i] != -1)
            {
                numbersOdd[j] = accum[i];
                j++;
            }
        }

        return numbersOdd;
    }

    public static double[] SwapFirstAndSecondHalfArray(double[] numbers)
    {
        double[] copy = numbers.ToArray();
        double[] numbersSwap = copy;
        for (int i = 0; i < numbers.Length / 2; i++)
        {
            _ = numbers.Length % 2 == 0
            ? (copy[copy.Length / 2 + i], numbersSwap[i]) =
              (numbersSwap[i], copy[copy.Length / 2 + i])
            : (copy[copy.Length / 2 + 1 + i], numbersSwap[i]) =
              (numbersSwap[i], copy[copy.Length / 2 + 1 + i]);

        }

        return numbersSwap;
    }

    public static double[] SortSelectUp(double[] numbers)
    {
        double[] numbersSort = numbers.ToArray();
        for (int i = 0; i < numbersSort.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < numbersSort.Length; j++)
            {
                if (numbersSort[minIndex] > numbersSort[j])
                {
                    minIndex = j;
                }
            }
            (numbersSort[i], numbersSort[minIndex]) =
            (numbersSort[minIndex], numbersSort[i]);
        }

        return numbersSort;
    }

    public static double[] SortSelectDown(double[] numbers)
    {
        double[] numbersSort = numbers.ToArray();
        for (int i = 0; i < numbersSort.Length - 1; i++)
        {
            int maxIndex = i;
            for (int j = i + 1; j < numbersSort.Length; j++)
            {
                if (numbersSort[maxIndex] < numbersSort[j])
                {
                    maxIndex = j;
                }
            }
            (numbersSort[i], numbersSort[maxIndex]) =
            (numbersSort[maxIndex], numbersSort[i]);
        }

        return numbersSort;
    }

    public static double[] SortBubbleUp(double[] numbers)
    {
        double[] numbersSort = numbers.ToArray();
        for (int i = 0; i < numbersSort.Length; i++)
        {
            for (int j = 0; j < numbersSort.Length - 1 -i; j++)
            {
                if (numbersSort[j] > numbersSort[j+1])
                {
                    (numbersSort[j], numbersSort[j+1]) =
                    (numbersSort[j + 1], numbersSort[j]);
                }
            }
        }

        return numbersSort;
    }

    public static double[] SortBubbleDown(double[] numbers)
    {
        double[] numbersSort = numbers.ToArray();
        for (int i = 0; i < numbersSort.Length; i++)
        {
            for (int j = 0; j < numbersSort.Length - 1 - i; j++)
            {
                if (numbersSort[j] < numbersSort[j + 1])
                {
                    (numbersSort[j], numbersSort[j + 1]) =
                    (numbersSort[j + 1], numbersSort[j]);
                }
            }
        }

        return numbersSort;
    }

    public static double[] SortInsertUp(double[] numbers)
    {
        double[] numbersSort = numbers.ToArray();
        for (int i = 1; i < numbersSort.Length; i++)
        {
            int j = i - 1;
            double min = numbersSort[i];
            while (j >= 0 && numbersSort[j] > min)
            {
                numbersSort[j + 1] = numbersSort[j];
                numbersSort[j] = min;
                j--;
            }
        }

        return numbersSort;
    }

    public static double[] SortInsertDown(double[] numbers)
    {
        double[] numbersSort = numbers.ToArray();
        for (int i = 1; i < numbersSort.Length; i++)
        {
            int j = i - 1;
            double max = numbersSort[i];
            while (j >= 0 && numbersSort[j] < max)
            {
                numbersSort[j + 1] = numbersSort[j];
                j--;
            }
            numbersSort[j + 1] = max;
        }

        return numbersSort;
    }
}