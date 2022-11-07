Console.WriteLine("Пожалуйста, введите первое число:");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число:");
double number2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите третье число:");
double number3 = Convert.ToDouble(Console.ReadLine());
if (number1 > number2 && number1 > number3 && number2 > number3)
{
    Console.WriteLine(number3 + " " + number2 + " " + number1);
}
else if (number1 > number2 && number1 > number3 && number3 > number2)
{
    Console.WriteLine(number2 + " " + number3 + " " + number1);
}
else if (number2 > number1 && number2 > number3 && number1 > number3)
{
    Console.WriteLine(number3 + " " + number1 + " " + number2);
}
else if (number2 > number1 && number2 > number3 && number3 > number1)
{
    Console.WriteLine(number1 + " " + number3 + " " + number2);
}
else if (number3 > number2 && number3 > number1 && number1 > number2)
{
    Console.WriteLine(number2 + " " + number1 + " " + number3);
}
else
{
    Console.WriteLine(number1 + " " + number2 + " " + number3);
}