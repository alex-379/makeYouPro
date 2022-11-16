namespace ProjectNumbers;

using ProjectNumbers;
class Program
{
    public static void Main(string[] args)
    {
        double a = OperationsWithNumbers.ReadFromConsole();
        double b = OperationsWithNumbers.ReadFromConsole();
        double c = OperationsWithNumbers.ReadFromConsole();
        double x = OperationsWithNumbers.ValueOfLinearEqution(a, b, c);
        OperationsWithNumbers.WriteResult(x);

        a = OperationsWithNumbers.ReadFromConsole();
        b = OperationsWithNumbers.ReadFromConsole();
        double result = OperationsWithNumbers.SumIfAMoreMultiplyIfEqualDifferenceIfBMore(a, b);
        OperationsWithNumbers.WriteResult(result);

        /*double res3 = OperationsWithNumbers.Number2DigitToString(a);
        Console.WriteLine($"\nРезультат действия с числами равен: {res3}");*/
    }
}
