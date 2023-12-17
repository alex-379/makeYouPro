Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
int aMirror = 0;
while (a != 0)
{
    int tmp = a % 10;
    a = a / 10;
    aMirror *= 10;
    aMirror += tmp;
}
Console.WriteLine(aMirror);