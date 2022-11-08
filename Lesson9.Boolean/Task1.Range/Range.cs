Console.WriteLine("Пожалуйста, введите число:");
double number = Convert.ToDouble(Console.ReadLine());
if (number >= 0 && number <= 10)
{
    Console.WriteLine("Введёное число входит в диапазон от 0 до 10");
}
else if (number >= 20 && number <= 30)
{
    Console.WriteLine("Введёное число входит в диапазон от 20 до 30");
}
else if (number >= 40 && number <= 50)
{
    Console.WriteLine("Введёное число входит в диапазон от 40 до 50");
}
else
{
    Console.WriteLine("Введёное число не входит ни в один из заданных диапазонов");
}