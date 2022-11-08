Console.WriteLine("Введите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
double num3 = Convert.ToDouble(Console.ReadLine());
double tmp = num1;
if (num1 < num2)
{
    num1 = num2;
    num2 = tmp;
}
if (num1 < num3)
{
    tmp = num1;
    num1 = num3;
    num3 = tmp;
}
if (num2 < num3)
{
    tmp = num2;
    num2 = num3;
    num3 = tmp;
}
Console.WriteLine(num1 + " " + num2 + " " + num3);