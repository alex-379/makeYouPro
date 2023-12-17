namespace ProjectNumbers;

public static class OperationsWithNumbers
{
    public static double ReadNumberFromConsole(string characteristic = "", string nameVar = "")
    {
        string s;
        double n = 0.0;
        bool isNumber = false;
        while (!isNumber)
        {
            Console.WriteLine($"Введите{characteristic} число{nameVar}: ");
            s = Console.ReadLine() ?? string.Empty;
            isNumber = double.TryParse(s, out n);
            if (!isNumber)
            {
                Console.WriteLine("Вы ввели некорректные данные.");
            }
            else
            {
                n = Convert.ToDouble(s);
            }
        }

        return n;
    }

    public static int ReadNumberIntFromConsole(string characteristic = "", string nameVar = "")
    {
        string s;
        int n = 0;
        bool isNumberInt = false;
        while (!isNumberInt)
        {
            Console.WriteLine($"Введите{characteristic} число{nameVar}: ");
            s = Console.ReadLine() ?? string.Empty;
            isNumberInt = int.TryParse(s, out n);
            if (!isNumberInt)
            {
                Console.WriteLine("Вы ввели некорректные данные.");
            }
            else
            {
                n = Convert.ToInt32(s);
            }
        }

        return n;
    }

    public static int ReadNumber2DigitFromConsole(string characteristic = "", string nameVar = "")
    {
        int n = 0;
        while (n < 10 || n >= 100)
        {
            n = ReadNumberIntFromConsole(characteristic, nameVar);
            if (n < 10 || n >= 100)
            {
                Console.WriteLine("Вы ввели некорректные данные.");
            }
        }

        return n;
    }

    public static int ReadNumberPositiveFromConsole(string characteristic = "", string nameVar = "")
    {
        int n = 0;
        while (n <= 0)
        {
            n = ReadNumberIntFromConsole(characteristic, nameVar);
            if (n <= 0)
            {
                Console.WriteLine("Вы ввели некорректные данные.");
            }
        }

        return n;
    }

    public static void WriteResult(double result, string nameResult) => Console.WriteLine($"{nameResult}: {result}\n");

    public static void WriteResult(string result, string nameResult) => Console.WriteLine($"{nameResult}: {result}\n");

    public static void WriteResult(bool result, string nameResult) => Console.WriteLine($"{nameResult}: {result}\n");

    public static double CalculateValueOfLinearEqution(double a, double b, double c)
    {
        if (a == 0)
        {
            throw new ArgumentException("a = 0. Деление на ноль невозможно");
        }
        double x = (c - b) / a;

        return (x);
    }

    public static double AddIfAMoreMultiplyIfEqualSubstractIfBMore(double a, double b, out string nameResult)
    {
        double result;
        if (a > b)
        {
            result = a + b;
            nameResult = "Сумма равна";
        }
        else if (a == b)
        {
            result = a * b;
            nameResult = "Произведение равно";
        }
        else
        {
            result = a - b;
            nameResult = "Разность равна";
        }

        return result;
    }

    public static string ConvertNumber2DigitToString(int n)
    {
        string s = "";

        if (n >= 10 && n < 20)
        {
            switch (n)
            {
                case 10:
                    s = "десять";
                    break;
                case 11:
                    s = "одиннадцать";
                    break;
                case 12:
                    s = "двенадцать";
                    break;
                case 13:
                    s = "тринадцать";
                    break;
                case 14:
                    s = "четырнадцать";
                    break;
                case 15:
                    s = "пятнадцать";
                    break;
                case 16:
                    s = "шестнадцать";
                    break;
                case 17:
                    s = "семнадцать";
                    break;
                case 18:
                    s = "восемнадцать";
                    break;
                case 19:
                    s = "девятнадцать";
                    break;
            }
        }
        else if (n >= 20 && n < 100)
        {
            int digit1 = n / 10;
            int digit2 = n % 10;
            string letter1 = "";
            string letter2 = "";

            switch (digit1)
            {
                case 2:
                    letter1 = "двадцать";
                    break;
                case 3:
                    letter1 = "тридцать";
                    break;
                case 4:
                    letter1 = "сорок";
                    break;
                case 5:
                    letter1 = "пятьдесят";
                    break;
                case 6:
                    letter1 = "шестьдесят";
                    break;
                case 7:
                    letter1 = "семьдесят";
                    break;
                case 8:
                    letter1 = "восемьдесят";
                    break;
                case 9:
                    letter1 = "девяносто";
                    break;
            }

            switch (digit2)
            {
                case 1:
                    letter2 = "один";
                    break;
                case 2:
                    letter2 = "два";
                    break;
                case 3:
                    letter2 = "три";
                    break;
                case 4:
                    letter2 = "четыре";
                    break;
                case 5:
                    letter2 = "пять";
                    break;
                case 6:
                    letter2 = "шесть";
                    break;
                case 7:
                    letter2 = "семь";
                    break;
                case 8:
                    letter2 = "восемь";
                    break;
                case 9:
                    letter2 = "девять";
                    break;
            }
            s = ($"{letter1} {letter2}");
        }

        return s;
    }

    public static bool CheckEnteringInRange(double n)
    {
        bool result = false;
        if (0 <= n && n <= 10 || 20 <= n && n <= 30 || 40 <= n && n <= 50)
        {
            result = true;
        }

        return result;
    }

    public static double AddNumbersDivisibleBy7(double a, double b)
    {
        double result = 0;
        double left = Math.Ceiling(a);
        for (double i = left; i <= b; i++)
        {

            if (i % 7 == 0)
            {
                result += i;
            }
        }

        return result;
    }

    public static int ReturnNumberNOfRowFibbonachi(int n)
    {
        int fibN = 0;
        if (n <= 2)
        {
            fibN = 1;
        }
        else
        {
            int fib1 = 1;
            int fib2 = 1;
            for (int i = 2; i < n; i++)
            {
                fibN = fib1 + fib2;
                fib1 = fib2;
                fib2 = fibN;
            }
        }

        return fibN;
    }

    public static int CountOddDigitsOfNumber(int n)
    {
        int count = 0;
        while (n != 0)
        {
            int tmp = n % 10;
            if (tmp % 2 != 0)
            {
                count++;
            }
            n /= 10;
        }

        return count;
    }

    public static int MirrorNumber(int n)
    {
        int aMirror = 0;
        while (n != 0)
        {
            int tmp = n % 10;
            n /= 10;
            aMirror *= 10;
            aMirror += tmp;
        }

        return aMirror;
    }

    public static bool CheckOnIdentity(int n, int n2)
    {
        bool result = false;

        if (n == 0 && n2 == 0)
        {
            result = true;
        }

        while (n != 0)
        {
            int digA = n % 10;
            int tmp = n2;
            while (n2 != 0)
            {
                int digB = n2 % 10;
                if (digB == digA)
                {
                    result = true;
                    break;
                }
                n2 /= 10;
            }
            if (result == true)
            {
                break;
            }
            else
            {
                n /= 10;
                n2 = tmp;
            }
        }

        return result;
    }
}
