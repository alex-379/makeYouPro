Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Результат умножения A на B: " + A * B);
Console.WriteLine("Остаток от деления B на A: " + B % A);
await Task.Delay(2000);