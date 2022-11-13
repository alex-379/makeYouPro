Console.WriteLine("Введите положительное число A: ");
int a = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <= a; i++)
{
    int s = 0;
    int j = i;
    while (j != 0)
    {
        int tmp = j % 10;
        s += tmp;
        j /= 10;
    }
    Console.WriteLine($"Сумма цифр {i} = {s}");
}