Console.WriteLine("Пожалуйста, введите первое число:");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число:");
double number2 = Convert.ToDouble(Console.ReadLine());
if (number1 == number2)
{
    Console.WriteLine("Введёные числа одинаковые");
}
else if (number1 > number2)
{
    Console.WriteLine("Число '" + number1 + "' больше числа '" + number2 + "' на " + (number1 - number2));
}
else
{
    Console.WriteLine("Число '" + number2 + "' больше числа '" + number1 + "' на " + (number2 - number1));
}