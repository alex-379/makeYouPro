Console.WriteLine("Введите число A: ");
string aString = Console.ReadLine();
int a = Convert.ToInt32(aString);
Console.WriteLine("Введите число B: ");
string bString = Console.ReadLine();
int b = Convert.ToInt32(bString);
int sum = 0;
Console.WriteLine();
for (int i = a ; i <= b; i ++)
{
    if (i % 7 == 0)
        sum += i;
}
Console.WriteLine("Сумма всех чисел в диапазоне от A до B, делящихся на 7:" + " " + sum);