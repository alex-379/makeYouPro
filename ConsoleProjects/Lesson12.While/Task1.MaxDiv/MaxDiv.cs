Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
int tmp = a - 1;
while (a % tmp != 0)
{
    tmp--;
}
Console.WriteLine(tmp);