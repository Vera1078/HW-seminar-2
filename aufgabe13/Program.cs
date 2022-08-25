System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine ());

string str = Convert.ToString (number);

if (number < 100)
{
    System.Console.WriteLine("Третьей цифры нет.");
}

else
{
Console.WriteLine (str [2]);
}