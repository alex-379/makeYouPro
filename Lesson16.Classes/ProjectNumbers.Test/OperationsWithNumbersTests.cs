namespace ProjectNumbers.Test;
public class OperationsWithNumbersTests
{
    [TestCase(3, 5, 8, 1)]
    [TestCase(-3, -5, -8, 1)]
    [TestCase(5, -5, 10, 3)]
    [TestCase(1, 0, 0, 0)]
    [TestCase(5, 2.3, 12.3, 2)]

    public void CalculateValueOfLinearEqutionTest(double a, double b, double c, double expected)
    {
        double actual = OperationsWithNumbers.CalculateValueOfLinearEqution(a, b, c);

        Assert.That(actual, Is.EqualTo(expected));        
    }


    [TestCase(5, 3, 8)]
    [TestCase(-3, -15, -18)]
    [TestCase(5, -15, -10)]
    [TestCase(0, 0, 0)]
    [TestCase(2, 2, 4)]
    [TestCase(-2, -2, 4)]
    [TestCase(-5, 2, -7)]
    [TestCase(-15, -10, -5)]
    [TestCase(5, 100, -95)]
    [TestCase(5.5, 3.5, 9)]
    [TestCase(1.5, 1.5, 2.25)]
    [TestCase(-1.5, -0.5, -1)]


    public void AddIfAMoreMultiplyIfEqualSubstractIfBMoreTest(double a, double b, double expected)
    {
        double actual = OperationsWithNumbers.AddIfAMoreMultiplyIfEqualSubstractIfBMore(a, b, out _);

        Assert.That(actual, Is.EqualTo(expected));
    }


    [TestCase(-8, 8, 0)]
    [TestCase(6, 15, 21)]
    [TestCase(14, 28, 63)]
    [TestCase(0, 21, 42)]
    [TestCase(-21, 0, -42)]
    [TestCase(0, 0, 0)]
    [TestCase(-15.5, 17.5, 0)]

    public void AddNumbersDivisibleBy7Test(double a, double b, double expected)
    {
        double actual = OperationsWithNumbers.AddNumbersDivisibleBy7(a, b);

        Assert.That(actual, Is.EqualTo(expected));
    }


    [TestCase(1, 1)]
    [TestCase(2, 1)]
    [TestCase(3, 2)]
    [TestCase(10, 55)]
    [TestCase(13, 233)]
    [TestCase(15, 610)]
    [TestCase(17, 1597)]

    public void ReturnNumberNOfRowFibbonachiTest(int n, int expected)
    {
        int actual = OperationsWithNumbers.ReturnNumberNOfRowFibbonachi(n);

        Assert.That(actual, Is.EqualTo(expected));
    }


    [TestCase(2, 0)]
    [TestCase(12, 1)]
    [TestCase(123, 2)]
    [TestCase(1234, 2)]
    [TestCase(12345, 3)]
    [TestCase(123456, 3)]
    [TestCase(1234567, 4)]
    [TestCase(12345678, 4)]
    [TestCase(123456789, 5)]
    [TestCase(1234567890, 5)]

    public void CountOddDigitsOfNumberTest(int n, int expected)
    {
        int actual = OperationsWithNumbers.CountOddDigitsOfNumber(n);

        Assert.That(actual, Is.EqualTo(expected));
    }


    [TestCase(2, 2)]
    [TestCase(12, 21)]
    [TestCase(123, 321)]
    [TestCase(1234, 4321)]
    [TestCase(12345, 54321)]
    [TestCase(123456, 654321)]
    [TestCase(1234567, 7654321)]
    [TestCase(12345678, 87654321)]
    [TestCase(123456789, 987654321)]
    [TestCase(1234567890, 0987654321)]

    public void MirrorNumberTest(int n, int expected)
    {
        int actual = OperationsWithNumbers.MirrorNumber(n);

        Assert.That(actual, Is.EqualTo(expected));
    }
}