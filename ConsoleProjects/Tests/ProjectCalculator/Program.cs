using ProjectCalculator;

internal class Program
{
    private static void Main(string[] args)
    {
        int a = Calculator.ReadFromConsole();
        int b = Calculator.ReadFromConsole();
        int result = Calculator.Add(a, b);
        Calculator.WriteResult(result);

        Calculator.AllMethods();
    }
}