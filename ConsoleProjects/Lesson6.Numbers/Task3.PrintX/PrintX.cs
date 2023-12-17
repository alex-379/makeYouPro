Console.WriteLine("Введите число A");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число B");
double B = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число C");
double C = Convert.ToDouble(Console.ReadLine());
double X = (C - B) / A;
Console.WriteLine("Число X равно: " + X);
await Task.Delay(2000);