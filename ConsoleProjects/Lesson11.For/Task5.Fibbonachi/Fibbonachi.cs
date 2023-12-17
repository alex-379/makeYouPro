Console.WriteLine("Введите положительное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int fib1 = 1;
int fib2 = 1;
int fibSum = 0;
if (n <= 2)
{
    Console.WriteLine(1);
}
else
{
    for (int i = 2; i < n; i++)
    {
        fibSum = fib1 + fib2;
        fib1 = fib2;
        fib2 = fibSum;
    }
    Console.WriteLine(fibSum);
}