Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = a; i <= b; i++)
{
    bool f = true;
    if (i <= 1)
    {
        f = false;
    }
    else
    {
        for (int j = 2; j * j <= i; j++)
        {
            if (i % j == 0)
            {
                f = false;
                break;
            }
        }
        if (f)
        {
            count++;
        }
    }
}
Console.WriteLine($"\nКоличество простых чисел в диапазоне от {a} до {b} равно: {count}");