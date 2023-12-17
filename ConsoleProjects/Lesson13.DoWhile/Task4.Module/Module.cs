Console.WriteLine("Введите последовательность чисел, заканчивающуюся '0': ");
int n = 0;
int pos = 0;
int neg = 0;
do
{
    n = Convert.ToInt32(Console.ReadLine());
    if (n > 0)
    {
        pos += n;
    }
    else
    {
        neg += Math.Abs(n);
    }
}
while (n != 0);

if (pos > neg)
{
    Console.WriteLine("Модуль суммы положительных чисел больше.");
}
else if (pos < neg)
{
    Console.WriteLine("Модуль суммы отрицательных чисел больше.");
}
else
{
    Console.WriteLine("Модули сумм отрицательных и положительных чисел равны.");
}
