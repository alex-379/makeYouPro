string pass = "";
do
{
    Console.WriteLine("Введите пароль: ");
    pass = Console.ReadLine();
}
while (pass != "Pass123!");
Console.WriteLine("Пароль принят");