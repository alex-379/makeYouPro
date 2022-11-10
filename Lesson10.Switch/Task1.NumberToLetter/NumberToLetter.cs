Console.WriteLine("Введите двузначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit1  = number / 10;
int digit2 = number % 10;
string letter1 = "";
string letter2 = "";
if (number >= 10 && number < 20)
{
    switch (number)
    {
        case 10:
            Console.WriteLine("Десять");
            break;
        case 11:
            Console.WriteLine("Одиннадцать");
            break;
        case 12:
            Console.WriteLine("Двенадцать");
            break;
        case 13:
            Console.WriteLine("Тринадцать");
            break;
        case 14:
            Console.WriteLine("Четырнадцать");
            break;
        case 15:
            Console.WriteLine("Пятнадцать");
            break;
        case 16:
            Console.WriteLine("Шестнадцать");
            break;
        case 17:
            Console.WriteLine("Семнадцать");
            break;
        case 18:
            Console.WriteLine("Восемнадцать");
            break;
        case 19:
            Console.WriteLine("Девятнадцать");
            break;
    }
}
else if (number >= 20 && number < 100)
{

    switch (digit1)
    {
        case 2:
            letter1 = "Двадцать";
            break;
        case 3:
            letter1 = "Тридцать";
            break;
        case 4:
            letter1 = "Сорок";
            break;
        case 5:
            letter1 = "Пятьдесят";
            break;
        case 6:
            letter1 = "Шестьдесят";
            break;
        case 7:
            letter1 = "Семьдесят";
            break;
        case 8:
            letter1 = "Восемьдесят";
            break;
        case 9:
            letter1 = "Девяносто";
            break;
    }
    switch (digit2)
    {
        case 1:
            letter2 = "один";
            break;
        case 2:
            letter2 = "два";
            break;
        case 3:
            letter2 = "три";
            break;
        case 4:
            letter2 = "четыре";
            break;
        case 5:
            letter2 = "пять";
            break;
        case 6:
            letter2 = "шесть";
            break;
        case 7:
            letter2 = "семь";
            break;
        case 8:
            letter2 = "восемь";
            break;
        case 9:
            letter2 = "девять";
            break;
    }
    Console.WriteLine(letter1 + " " + letter2);
}
else Console.WriteLine("Введено не двузначное число");