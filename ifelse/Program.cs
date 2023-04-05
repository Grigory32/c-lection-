Console.Write("введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Любимая, Машунечка");
}

else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}