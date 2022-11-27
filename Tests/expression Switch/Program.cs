
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((i % 2 == 0) ? $"{i} - четное число" : $"{i} - нечетное число");

double[] numbers = new[] { 1.0, 2, 3, 4, 5 };
SwapFirstAndSecondHalfArray(numbers);

static double[] SwapFirstAndSecondHalfArray(double[] numbers)
{
    double[] numbersSwap = numbers;
    if (numbers.Length % 2 == 0)
    {
        for (int i = 0; i < numbers.Length / 2; i++)
        {
            (numbers[numbers.Length / 2 + i], numbersSwap[i]) =
            (numbersSwap[i], numbers[numbers.Length / 2 + i]);
        }
    }
    else
    {
        for (int i = 0; i < numbers.Length / 2; i++)
        {
            (numbers[numbers.Length / 2 + 1 + i], numbersSwap[i]) =
            (numbersSwap[i], numbers[numbers.Length / 2 + 1 + i]);
        }
    }

    return (numbers.Length % 2 == 0) switch
    {
        true => numbersSwap,
        false => numbersSwap,
    };
}

