Console.WriteLine("Введите целое положительное число: ");
int s = Convert.ToInt32(Console.ReadLine());
double a = 1;
double b = s;
double eps = 0.00000001;
while (Math.Abs(b - a) > eps)
{
    double c = (a + b) / 2;
    if ((a * a * a - s) * (c * c * c - s) < 0)
    {
        b = c;
    }
    else
    {
        a = c;
    }
}
Console.WriteLine((a + b) / 2);