Console.WriteLine("Введите Ваше имя");
string firstName = Console.ReadLine();
Console.WriteLine("Введите Вашу фамилию");
string lastName = Console.ReadLine();
Console.WriteLine("Введите Ваше отчество");
string patronymic = Console.ReadLine();
string allName = lastName + " " + firstName + " " + patronymic;
Console.WriteLine(allName);
await Task.Delay(2000);