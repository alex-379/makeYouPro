Console.WriteLine("Введите число A: ");
string aString = Console.ReadLine();
int a = Convert.ToInt32(aString);
Console.WriteLine("Все числа в диапазоне от 1 до 1000, делящиеся на A: ");
for (int i = a; i <= 1000; i+=a)
{
    Console.WriteLine(i);
}