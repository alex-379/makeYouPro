namespace ProjectNumbers;

using ProjectNumbers;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите число A: ");
        string aString = Console.ReadLine();
        int a = Convert.ToInt32(aString);

        Console.WriteLine("Введите число B: ");
        string bString = Console.ReadLine();
        int b = Convert.ToInt32(bString);

        Console.WriteLine("Введите число C: ");
        string cString = Console.ReadLine();
        int c = Convert.ToInt32(cString);

        double res1 = OperationsWithNumbers.ValueOfLinearEqution(a, b, c);
        Console.WriteLine($"\nРешение линейного уравнения равно: {res1}");

        double res2 = OperationsWithNumbers.SumIfAMoreMultiplyIfEqualDifferenceIfBMore(a, b);
        Console.WriteLine($"\nРезультат действия с числами равен: {res2}");
        
        double res3 = OperationsWithNumbers.Number2DigitToString(a);
        Console.WriteLine($"\nРезультат действия с числами равен: {res3}");
    }
}
