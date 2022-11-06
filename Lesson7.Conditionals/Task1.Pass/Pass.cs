Console.WriteLine("Введите пароль:");
string a = Console.ReadLine();
if (a == "QWERTY123")
{
    Console.WriteLine("Пароль совпадает с \"QWERTY123\"");
}
await Task.Delay(2000);