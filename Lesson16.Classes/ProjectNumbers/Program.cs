namespace ProjectNumbers;

using ProjectNumbers;
using System.Reflection.Metadata;

class Program
{
    public static void Main(string[] args)
    {
        double a = OperationsWithNumbers.ReadNumberFromConsole(nameVar: " A");
        double b = OperationsWithNumbers.ReadNumberFromConsole(nameVar: " B");
        double c = OperationsWithNumbers.ReadNumberFromConsole(nameVar: " C");
        double result = OperationsWithNumbers.CalculateValueOfLinearEqution(a, b, c);
        OperationsWithNumbers.WriteResult(result, "Значение X равно");

        a = OperationsWithNumbers.ReadNumberFromConsole(nameVar: " A");
        b = OperationsWithNumbers.ReadNumberFromConsole(nameVar: " B");
        result = OperationsWithNumbers.AddIfAMoreMultiplyIfEqualSubstractIfBMore(a, b, out string nameResult);
        OperationsWithNumbers.WriteResult(result, nameResult);

        int numberTwoDigit = OperationsWithNumbers.ReadNumber2DigitFromConsole(characteristic: " двузначное");
        string resultString = OperationsWithNumbers.ConvertNumber2DigitToString(numberTwoDigit);
        OperationsWithNumbers.WriteResult(resultString, $"Прописная запись числа {numberTwoDigit}");

        a = OperationsWithNumbers.ReadNumberFromConsole();
        bool resultBool = OperationsWithNumbers.CheckEnteringInRange(a);
        OperationsWithNumbers.WriteResult(resultBool, "Результат проверки на вхождение в диапазон");

        a = OperationsWithNumbers.ReadNumberFromConsole(nameVar: " A");
        b = OperationsWithNumbers.ReadNumberFromConsole(nameVar: " B");
        result = OperationsWithNumbers.AddNumbersDivisibleBy7(a, b);
        OperationsWithNumbers.WriteResult(result, $"Cумма чисел из диапазона от {a} до {b}, делящихся на 7");

        int n = OperationsWithNumbers.ReadNumberPositiveFromConsole(" положительное", " N");
        result = OperationsWithNumbers.ReturnNumberNOfRowFibbonachi(n);
        OperationsWithNumbers.WriteResult(result, $"{n}-е число ряда Фибоначчи");

        n = OperationsWithNumbers.ReadNumberIntFromConsole();
        result = OperationsWithNumbers.CountOddDigitsOfNumber(n);
        OperationsWithNumbers.WriteResult(result, $"Количество нечётных цифр числа {n}");

        n = OperationsWithNumbers.ReadNumberIntFromConsole();
        result = OperationsWithNumbers.MirrorNumber(n);
        OperationsWithNumbers.WriteResult(result, $"Зеркально отображение числа {n}");

        n = OperationsWithNumbers.ReadNumberIntFromConsole(nameVar: " 1");
        int n2 = OperationsWithNumbers.ReadNumberIntFromConsole(nameVar: " 2");
        resultBool = OperationsWithNumbers.CheckOnIdentity(n, n2);
        OperationsWithNumbers.WriteResult(resultBool, "Результат проверки на наличие одинаковых цифр");
    }
}
