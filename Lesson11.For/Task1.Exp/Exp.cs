Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int exp = 1;
for (int i = 1; i <= b; i++)
{
    exp *= a;
}
Console.WriteLine("Число A в степени B: " + exp);