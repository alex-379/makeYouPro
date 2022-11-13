Console.WriteLine("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
while (n1 != 0 && n2 != 0)
{
    if (n1 > n2)
        n1 %= n2;
    else
        n2 %= n1;
}
Console.WriteLine(n1 + n2);