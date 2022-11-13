Console.WriteLine("Введите последовательность чисел, заканчивающуюся '0': ");
int max = 0;
int n = 0;
do
    {
        n = Convert.ToInt32(Console.ReadLine());
    if (n > max)
    {
        max = n;
    }
    }
while (n != 0);
Console.WriteLine("Наибольшее число в последовательности: " + max);