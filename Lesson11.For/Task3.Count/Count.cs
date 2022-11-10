Console.WriteLine("Введите число A: ");
string aString = Console.ReadLine();
int a = Convert.ToInt32(aString);
int count = 0;
Console.WriteLine("Положительные целые числа, квадрат которых меньше A: ");
for (int i = 1; i*i < a; i++)
{
    count++;
}
Console.WriteLine(count);