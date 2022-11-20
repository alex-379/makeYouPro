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
        OperationsWithNumbers.WriteResult(result, "�������� X �����");

        a = OperationsWithNumbers.ReadNumberFromConsole(nameVar: " A");
        b = OperationsWithNumbers.ReadNumberFromConsole(nameVar: " B");
        result = OperationsWithNumbers.AddIfAMoreMultiplyIfEqualSubstractIfBMore(a, b, out string nameResult);
        OperationsWithNumbers.WriteResult(result, nameResult);

        int numberTwoDigit = OperationsWithNumbers.ReadNumber2DigitFromConsole(characteristic: " ����������");
        string resultString = OperationsWithNumbers.ConvertNumber2DigitToString(numberTwoDigit);
        OperationsWithNumbers.WriteResult(resultString, $"��������� ������ ����� {numberTwoDigit}");

        a = OperationsWithNumbers.ReadNumberFromConsole();
        bool resultBool = OperationsWithNumbers.CheckEnteringInRange(a);
        OperationsWithNumbers.WriteResult(resultBool, "��������� �������� �� ��������� � ��������");

        a = OperationsWithNumbers.ReadNumberFromConsole(nameVar: " A");
        b = OperationsWithNumbers.ReadNumberFromConsole(nameVar: " B");
        result = OperationsWithNumbers.AddNumbersDivisibleBy7(a, b);
        OperationsWithNumbers.WriteResult(result, $"C���� ����� �� ��������� �� {a} �� {b}, ��������� �� 7");

        int n = OperationsWithNumbers.ReadNumberPositiveFromConsole(" �������������", " N");
        result = OperationsWithNumbers.ReturnNumberNOfRowFibbonachi(n);
        OperationsWithNumbers.WriteResult(result, $"{n}-� ����� ���� ���������");

        n = OperationsWithNumbers.ReadNumberIntFromConsole();
        result = OperationsWithNumbers.CountOddDigitsOfNumber(n);
        OperationsWithNumbers.WriteResult(result, $"���������� �������� ���� ����� {n}");

        n = OperationsWithNumbers.ReadNumberIntFromConsole();
        result = OperationsWithNumbers.MirrorNumber(n);
        OperationsWithNumbers.WriteResult(result, $"��������� ����������� ����� {n}");

        n = OperationsWithNumbers.ReadNumberIntFromConsole(nameVar: " 1");
        int n2 = OperationsWithNumbers.ReadNumberIntFromConsole(nameVar: " 2");
        resultBool = OperationsWithNumbers.CheckOnIdentity(n, n2);
        OperationsWithNumbers.WriteResult(resultBool, "��������� �������� �� ������� ���������� ����");
    }
}
