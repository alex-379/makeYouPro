Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
bool f = true;
while (a != 0)
{
    int digA = a % 10;
    int tmp = b;
    while (b != 0)
    {
        int digB = b % 10;
        if (digB == digA)
        {
            f = false;
            break;
        }
        b = b / 10;
    }
    if (f == false)
    {
        break;
    }
    else
    {
        a = a / 10;
        b = tmp;
    }

}
if (f)
{
    Console.WriteLine("В написании чисел нет одинаковых цифр");
}
else
{
    Console.WriteLine("В написании двух чисел есть одинаковые цифры");
}