namespace ProjectNumbers;

using ProjectNumbers;
class Program
{
    public static void Main(string[] args)
    {
        double a = OperationsWithNumbers.ReadFromConsole();
        /*double b = OperationsWithNumbers.ReadFromConsole();
        double c = OperationsWithNumbers.ReadFromConsole();
        double x = OperationsWithNumbers.ValueOfLinearEqution(a, b, c);
        OperationsWithNumbers.WriteResult(x);

        a = OperationsWithNumbers.ReadFromConsole();
        b = OperationsWithNumbers.ReadFromConsole();
        double result = OperationsWithNumbers.SumIfAMoreMultiplyIfEqualDifferenceIfBMore(a, b);
        OperationsWithNumbers.WriteResult(result);*/

        a = OperationsWithNumbers.ReadFromConsole();
        string resultString = OperationsWithNumbers.Number2DigitToString(a);  

    }
}
