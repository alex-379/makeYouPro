Console.WriteLine("Введите последовательность чисел, заканчивающуюся '0': ");
int count = 0;
int n = 0;
do
{
    n = Convert.ToInt32(Console.ReadLine());
    if (n % 3 == 0 || n % 7 == 0 || n % 11 == 0)
    {
        count++;
    }
}
while (n != 0);
Console.WriteLine("Количество чисел в последовательности, делящихся на 3, 7 или 11: " + count);