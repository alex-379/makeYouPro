Console.WriteLine("Введите первое число:");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число:");
double b = Convert.ToDouble(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("Сумма A и B равна: " + (a + b));
}
if (a == b)
{
    Console.WriteLine("Произведение A и B равно: " + (a * b));
}
if (a < b)
{
    Console.WriteLine("Разница A и B равна: " + (a - b));
}
await Task.Delay(2000);