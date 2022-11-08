Console.WriteLine("Введите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
double num3 = Convert.ToDouble(Console.ReadLine());
if ((num2 > num3 && num1 > num2) || (num2 < num3 && num1 > num3))
{
    if (num2 + num3 > num1)
        Console.WriteLine("Cумма любых двух чисел больше третьего");
    else
        Console.WriteLine("Cумма двух наименьших чисел меньше третьего");
}
else if ((num1 > num3 && num2 > num1) || (num1 < num3 && num2 > num3))
{
    if (num1 + num3 > num2)
        Console.WriteLine("Cумма любых двух чисел больше третьего");
    else
        Console.WriteLine("Cумма двух наименьших чисел меньше третьего");
}
else
{
    if (num1 + num2 > num3)
        Console.WriteLine("Cумма любых двух чисел больше третьего");
    else
        Console.WriteLine("Cумма двух наименьших чисел меньше третьего");
}