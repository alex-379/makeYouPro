Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (a != 0)
{
    int tmp = a % 10;
    if (tmp % 2 != 0)
    {
        count++;
    }
    a = a / 10;
}
Console.WriteLine(count);