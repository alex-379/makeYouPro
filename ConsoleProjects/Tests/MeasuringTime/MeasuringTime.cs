using System.Diagnostics;
Console.WriteLine("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Stopwatch stopWatch = new Stopwatch();
stopWatch.Start();
while (n1 != n2)
    if (n1 > n2)
        n1 = n1 - n2;
    else
        n2 = n2 - n1;
Console.WriteLine(n1);
stopWatch.Stop();
Console.WriteLine(stopWatch.Elapsed);