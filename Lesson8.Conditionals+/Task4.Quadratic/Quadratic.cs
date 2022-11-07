using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Пожалуйста, введите первое число:");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число:");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите третье число:");
double c = Convert.ToDouble(Console.ReadLine());
double d = (b*b - 4*a*c);
if (d > 0)
{
    double x1 = (-b + Math.Sqrt(d)) / 2 * a;
    double x2 = (-b - Math.Sqrt(d)) / 2 * a;
    Console.WriteLine("Корни квадратного уравнения равны: " + x1 + " " + x2);
}
else if (d == 0)
{
    double x = -b / 2 * a;
    Console.WriteLine("Корень квадратного уравнения равен: " + x);
}
else
{
    Console.WriteLine("Действительных корней нет");
}